namespace KoreanLearning.Core
{
    internal class LoadExcelData
    {
        //public static List<Characters> LoadExcelDataM(string filePath)
        //{
        //    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        //    var vocabularyList = new List<Characters>();

        //    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
        //    {
        //        using (var reader = ExcelReaderFactory.CreateReader(stream))
        //        {
        //            var result = reader.AsDataSet();
        //            var table = result.Tables[0]; // Assuming data is in the first sheet

        //            for (int i = 1; i < table.Rows.Count; i++) // Skip header row
        //            {
        //                var character = table.Rows[i][0]?.ToString();
        //                var pronounciation = table.Rows[i][1]?.ToString();

        //                if (!string.IsNullOrWhiteSpace(character) && !string.IsNullOrWhiteSpace(pronounciation))
        //                {
        //                    vocabularyList.Add(new Characters
        //                    {
        //                        Character = character,
        //                        Pronounciation = pronounciation
        //                    });
        //                }
        //            }
        //        }
        //    }

        //    return vocabularyList;
        //}
    }

    
}
