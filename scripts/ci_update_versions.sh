# Update FileVersion
sed -i -r 's/(<FileVersion>[0-9]+\.[0-9]+\.[0-9]+\.)[0-9]+/\1$(GITHUB_RUN_NUMBER)/' dss_sharp.csproj

if [ "tag" == "${GITHUB_REF_TYPE}" ]; then
    sed -i -r 's/<PackageVersion>.*<\/PackageVersion>/<PackageVersion>$(GITHUB_REF_NAME)<\/PackageVersion>/' dss_sharp.csproj
fi

cat dss_sharp.csproj
