# grpc-nuget-example
Пример использования Nuget для распространения proto файлов по микросервисам

## Необходжимые компоненты

Необхоодимо внести в настройки %appdata%\NuGet\Nuget.config дополнительный локальный истоник пакетов

```xml
<add key="Local" value="C:\Nuget" />
```

## Запуск

1. Создать Nuget пакет Grpc.Nuget.Example.Protos.Messages командой ```dotnet pack --no-build -o C:\Nuget```, где C:\Nuget - ваш локальный путь для локальных nuget пакетов
2. Создать Nuget пакет Grpc.Nuget.Example.Protos.Service командой ```dotnet pack --no-build -o C:\Nuget```
3. Запустить проект Grpc.Nuget.Example.Server
4. Запустить клиент Grpc.Nuget.Example.Client

## Proto файлы

- *ExampleMessages.proto* - описание общих для нескольких микросервисов моделей
- *ExampleRpcService.proto* - описание RPC сервиса
