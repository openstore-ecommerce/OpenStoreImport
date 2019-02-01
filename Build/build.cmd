@echo off

set MSBUILD_HOME=%WINDIR%\Microsoft.NET\Framework\v4.0.30319
set MSBUILD_EXE=%MSBUILD_HOME%\msbuild.exe
set BUILD_DIR=%~dp0

REM ensure MSBuild is available
if not exist %MSBUILD_EXE% call msbuild_not_found & pause & exit /b 1

call %MSBUILD_EXE% %BUILD_DIR%build.proj /nologo /t:Build /verbosity:minimal
if errorlevel 1 call :deploy_error & pause & exit /b 1
echo.
echo Build and deploy finished successfully.
echo.
pause
goto :EOF

:deploy_error
echo.
echo FAILURE:
echo Deployment failed.
goto :EOF

:msbuild_not_found
echo.
echo FAILURE:
echo MSBuild not found in %MSBUILD_HOME%.
echo.
goto :EOF
