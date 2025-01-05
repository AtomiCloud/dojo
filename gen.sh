#!/usr/bin/env bash

set -euo pipefail

level="$1"
question="$2"
name="$3"

if [[ -z $level ]]; then
  echo "Usage: $0 <level> <question> <name>"
  exit 1
fi

if [[ -z $question ]]; then
  echo "Usage: $0 <level> <question> <name>"
  exit 1
fi

if [[ -z $name ]]; then
  echo "Usage: $0 <level> <question> <name>"
  exit 1
fi

folder="./levels/$level/$question-$name"

mkdir -p "$folder"

touch "$folder/README.MD"

cp ./template/*.cs "$folder"
cp ./template/*.ts "$folder"
cp ./template/*.go "$folder"
cp ./template/*.py "$folder"

QUESTION="$question" NAME="$name" gomplate -f "template/proj.csproj" -o "$folder/$question-$name.csproj"

yq eval ".includes.\"$level:$question\" = { \"taskfile\": \"Taskfile.language.yaml\", \"dir\": \"levels/$level/$question-$name\" }" -i Taskfile.yaml

yq eval ".tasks.setup.cmds += \"pls $level:$question:setup\"" -i Taskfile.yaml

cd "$folder" || exit

go mod init "github.com/AtomiCloud/levels/$level/$question-$name"
go mod tidy
