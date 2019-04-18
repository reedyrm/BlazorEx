#!/bin/bash

cd ..

echo "Building Release Version..."
dotnet publish -c Release

echo "Copying artifacts to /docs"
cp -av ./bin/Release/netstandard2.0/publish/BlazorEx/dist/. ./docs
