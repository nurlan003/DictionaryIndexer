using System;
using System.Collections.Generic;

public class DictionaryProgram
{
    private static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    public string this[string word]
    {
        get
        {
            if (dictionary.ContainsKey(word))
                return dictionary[word];
            else
                return "Daxil etdiyiniz soz lugetde movcud deyil!!!";
        }
    }

    public static void Main(string[] args)
    {
        DictionaryProgram dictionaryProgram = new DictionaryProgram();
        dictionaryProgram.CreateDictionary();
        while (true)
        {
            Console.WriteLine("Enter your word");
            string word = Console.ReadLine();


            string meaning = dictionaryProgram[word];
            Console.WriteLine("menasi: " + meaning);
        }

        Console.WriteLine("lugetden cixidli!");
    }

    public void CreateDictionary()
    {
        dictionary.Add("nar", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("armud", "şirin və yumşaq tərkibə sahib meyvə");
        dictionary.Add("qarpız", "sarı, çəkisi olan, dadlı meyvə");
        dictionary.Add("üzüm", "qara, ağ və ya qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("şəftali", "sarı və ya çəhre rengdə, dadlı meyvə");
        dictionary.Add("albalı", "ağ rəngdə, dadlı meyvə");
        dictionary.Add("ananas", "sarı, dadlı meyvə");
        dictionary.Add("armelan", "qırmızı və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("avokado", "yaşıl rəngdə, yağlı meyvə");
        dictionary.Add("ayva", "sarı və ya qırmızı rəngdə, şirin meyvə");
        dictionary.Add("banan", "sarı rəngdə, dadlı meyvə");
        dictionary.Add("çərəz", "çəkisi olan, dadlı meyvə");
        dictionary.Add("çiyələk", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("dananə", "beyaz və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("dəli", "qara və ya qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("fındıqqozu", "beyaz, dadlı meyvə");
        dictionary.Add("gilas", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("görək", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("iyri", "beyaz və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("kəndir", "beyaz və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("kivi", "kəhrəba rəngdə, dadlı meyvə");
        dictionary.Add("limon", "sarı rəngdə, dadlı meyvə");
        dictionary.Add("mandalina", "sarı rəngdə, dadlı meyvə");
        dictionary.Add("mesir", "qara rəngdə, dadlı meyvə");
        dictionary.Add("narınc", "sarı rəngdə, dadlı meyvə");
        dictionary.Add("obad", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("pişik", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("qaranfil", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("qaz", "qəhvəyi rəngdə, dadlı meyvə");
        dictionary.Add("quş", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("riyaz", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("şaftalı", "sarı və ya çəhre rengdə, dadlı meyvə");
        dictionary.Add("şəbəkə", "qırmızı və ya qara rəngdə, dadlı meyvə");
        dictionary.Add("şeker", "ağ və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("tun", "sarı rəngdə, dadlı meyvə");
        dictionary.Add("tünd", "qara rəngdə, dadlı meyvə");
        dictionary.Add("ülem", "qırmızı və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("üzümçi", "qara, ağ və ya qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("vişna", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("yarıq", "qırmızı rəngdə, dadlı meyvə");
        dictionary.Add("yüngül", "qara rəngdə, dadlı meyvə");
        dictionary.Add("zəncəfil", "qırmızı və ya sarı rəngdə, dadlı meyvə");
        dictionary.Add("zeytun", "yaşıl rəngdə, dadlı meyvə");
    }
}