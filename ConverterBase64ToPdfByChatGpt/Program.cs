namespace ConvertBase64ToPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo a lista de strings em base64 e a pasta de destino
            List<string> base64List = new List<string> { "string-base64-1", "string-base64-2", "string-base64-3" };
            string destinationFolder = "C:\\Downloads\\PDFs\\";

            // Loop para percorrer a lista de strings em base64
            for (int i = 0; i < base64List.Count; i++)
            {
                // Convertendo a string em base64 em um array de bytes
                byte[] pdfBytes = Convert.FromBase64String(base64List[i]);

                // Criando um novo arquivo PDF na pasta de destino
                FileStream pdfFile = new FileStream(destinationFolder + "file" + i + ".pdf", FileMode.Create);

                // Escrevendo os bytes convertidos no arquivo
                pdfFile.Write(pdfBytes, 0, pdfBytes.Length);

                // Fechando o arquivo
                pdfFile.Close();
            }

            // Exibindo uma mensagem de conclusão
            Console.WriteLine("Arquivos PDF convertidos e salvos em: " + destinationFolder);
        }
    }
}