
using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace AndroidKeystoreCreator.Services;

public class KeystoreService
{
    public string GenerateKeystore()
    {
        string output = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "android_keystore.p12");
        using var rsa = RSA.Create(2048);
        var req = new CertificateRequest("CN=AndroidApp", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        var cert = req.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(25));

        byte[] pfx = cert.Export(X509ContentType.Pkcs12, "password");
        File.WriteAllBytes(output, pfx);
        return output;
    }
}
