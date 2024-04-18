using System;

public class Class1
{
	public Class1()
	{


    public string Path { get; set; }
    public char Delimiter { get; set; }
    public bool SkipHeader { get; set; }

    public List<Eredmeny> FindAll()
    {
        StreamReader r = new StreamReader(this.Path, true);
        if (this.SkipHeader) { r.ReadLine(); }

        List<Eredmeny> eredmenyListOutput = new List<Eredmeny> { };

        while (!r.EndOfStream)
        {
            eredmenyListOutput.Add(new Eredmeny(r.ReadLine()));
        }
        return eredmenyListOutput;
    }




}
}
