# demo-grpc
Demo how to development gRPC with C#

1. Open .sln and restore nuget from .csproj
2. Execute below command on root folder to generate .cs files on `Demo.Message`:
    ```sh
    /Users/`whoami`/.nuget/packages/grpc.tools/1.18.0/tools/macosx_x64/protoc -I ./protos/ --csharp_out src/Demo.Message --grpc_out src/Demo.Message ./protos/*.proto --plugin=protoc-gen-grpc=/Users/`whoami`/.nuget/packages/grpc.tools/1.18.0/tools/macosx_x64/grpc_csharp_plugin 
    ```
3. Run `Demo.Server`
4. Run `Demo.Client` and get it!