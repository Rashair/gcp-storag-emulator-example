# gcp-storage-emulator-example

1. Run the app via 
```
docker compose up -d 
dotnet run
```

2. Go to `https://localhost:7144/swagger`


3. Upload a big file (+5mb)
![image](https://user-images.githubusercontent.com/33404585/197570405-46d7166c-cac4-4fd5-8853-7779504090d9.png)

4. Execute the method

5. There's an error

```
System.Net.Http.HttpRequestException: IPv4 address 0.0.0.0 and IPv6 address ::0 are unspecified addresses that cannot be used as a target address. (Parameter 'hostName') (0.0.0.0:9023)
 ---> System.ArgumentException: IPv4 address 0.0.0.0 and IPv6 address ::0 are unspecified addresses that cannot be used as a target address. (Parameter 'hostName')
   at System.Net.Dns.GetHostEntryOrAddressesCoreAsync(String hostName, Boolean justReturnParsedIp, Boolean throwOnIIPAny, Boolean justAddresses, AddressFamily family, CancellationToken cancellationToken)
```

