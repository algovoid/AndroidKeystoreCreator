#!/usr/bin/env bash

dotnet publish src/AndroidKeystoreCreator -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true