rm -rf ./**/**/obj ./**/**/bin

find . -not -iwholename '.git' -type f -print0 | xargs -0 sed -i 's/Gma\.//g'
find . -depth -not -iwholename '.git' -type d -name 'Gma*' -exec bash -c 'mv "$1" "${1/Gma\./}"' - '{}' \;
find . -not -iwholename '.git' -type f -name 'Gma*' -exec bash -c 'mv "$1" "${1/Gma\./}"' - '{}' \;

dotnet restore
dotnet build
dotnet test
echo 'Done!'