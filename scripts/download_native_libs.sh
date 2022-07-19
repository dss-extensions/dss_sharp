if [ -z ${DSS_CAPI_TAG+x} ]; then
    DSS_CAPI_TAG=0.12.1
fi

rm -rf runtimes messages
mkdir runtimes
cd runtimes
echo Downloading...
curl -s -L https://github.com/dss-extensions/dss_capi/releases/download/${DSS_CAPI_TAG}/dss_capi_${DSS_CAPI_TAG}_linux_x64.tar.gz -o linux.tar.gz
curl -s -L https://github.com/dss-extensions/dss_capi/releases/download/${DSS_CAPI_TAG}/dss_capi_${DSS_CAPI_TAG}_darwin_x64.tar.gz -o macos.tar.gz
curl -s -L https://github.com/dss-extensions/dss_capi/releases/download/${DSS_CAPI_TAG}/dss_capi_${DSS_CAPI_TAG}_darwin_arm64.tar.gz -o macosarm.tar.gz
curl -s -L https://github.com/dss-extensions/dss_capi/releases/download/${DSS_CAPI_TAG}/dss_capi_${DSS_CAPI_TAG}_win_x64.zip -o win64.zip
# curl -s -L https://github.com/dss-extensions/dss_capi/releases/download/${DSS_CAPI_TAG}/dss_capi_${DSS_CAPI_TAG}_win_x86.zip -o win32.zip
curl -s -L https://github.com/dss-extensions/dss_capi/releases/download/${DSS_CAPI_TAG}/messages.tar.gz -o messages.tar.gz

echo Unpacking...
unzip -q -o win64.zip
# unzip -q -o win32.zip
tar zxf linux.tar.gz
tar zxf macos.tar.gz
tar zxf macosarm.tar.gz
tar zxf messages.tar.gz

mkdir -p win-x64/native linux-x64/native osx-x64/native osx.11.0-arm64/native
# mkdir win-x86 
find . -name '*dss_capid*' -exec rm {} \;


mv dss_capi/lib/win_x64/*.dll ./win-x64/native/
# mv dss_capi/lib/win_x86/*.dll ./win-x86/native/
mv dss_capi/lib/linux_x64/*.so ./linux-x64/native/
mv dss_capi/lib/darwin_arm64/*.dylib ./osx.11.0-arm64/native/
mv dss_capi/lib/darwin_x64/*.dylib ./osx-x64/native/

mv messages ..

echo Clean-up...
rm *.zip *.tar.gz
rm -rf dss_capi

echo Done!