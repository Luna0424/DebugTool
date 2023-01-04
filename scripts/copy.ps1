$list = get-childitem C:\Users -attributes !H | select fullname
foreach ($file in $list){
    Copy-Item -Path $file -Destination "+drive+@"C\Users\
}