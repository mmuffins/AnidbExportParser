{
  pkgs,
  lib,
  config,
  ...
}:
{
  languages.dotnet = {
    enable = true;
    package = pkgs.dotnet-sdk_10;
  };

  tasks."parser:convert" = {
    description = "Convert a mylist.xml TGZ export to an AniDB database";
    exec = ''
      shopt -s nullglob
      convert_dir="$DEVENV_ROOT/convert"
      archives=("$convert_dir"/*.tgz)
      if (( ''${#archives[@]} == 0 )); then
        echo 'No TGZ file found in the convert folder.' >&2
        exit 2
      elif (( ''${#archives[@]} > 1 )); then
        echo 'Multiple TGZ files found in the convert folder; expected exactly one.' >&2
        exit 2
      fi

      archive="''${archives[0]}"
      tgz="$(basename "$archive")"

      epoch="''${tgz%%-*}"
      if [[ ! "$epoch" =~ ^[0-9]+$ ]]; then
        echo "The file name must start with an epoch timestamp followed by a minus: $tgz" >&2
        exit 2
      fi

      export_date="$(${lib.getExe' pkgs.coreutils "date"} --utc --date="@$epoch" +%F)" || {
        echo "Invalid epoch timestamp in file name: $epoch" >&2
        exit 2
      }

      temp_dir="$(mktemp -d)"
      trap 'rm -rf "$temp_dir"' EXIT
      tar -xzf "$archive" -C "$temp_dir"

      input="$temp_dir/mylist.xml"
      if [[ ! -f "$input" ]]; then
        echo "Archive does not contain mylist.xml at its root: $tgz" >&2
        exit 2
      fi

      output="$convert_dir/anidbmylist_$export_date.db"

      "$DEVENV_ROOT/publish/ParserConsole" convert --input "$input" --output "$output"
      echo "Created $output"
    '';
  };

}
