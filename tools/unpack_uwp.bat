REM The script unpacks UWP SDKs and places dependencies where appropriate.

@echo off

FOR /F %%I IN ('DIR *Windows*.zip /b /O:D') DO set PACKAGE_WINDOWS=%%I

set TMP_UWP=tmp_uwp

REM Cleanup
rd /s /q tmp_uwp

REM unzip dependencies
7z x %PACKAGE_WINDOWS% -o%TMP_UWP%

REM Copy dependencies
pushd "%TMP_UWP%\lib\EnRouteApi\libs"
	xcopy * ..\..\..\..\..\source\EnRouteApiUWP\lib\ /Y
popd
