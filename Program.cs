string? path;
string[] files;
StreamWriter hoja = new StreamWriter("Archivos.csv");
path = Console.ReadLine();
Console.WriteLine(path);
if (path != null)
{
    files = Directory.GetFiles(path);
    if (files != null)
    {
        for (int i = 0; i < files.Length; i++)
        {
            // Tipo de objeto FileInfo para obtener su extensión
            FileInfo found = new FileInfo(files[i]);

            // Obtiene el nombre reducido (found.Name) y remueve su extensión (String.Remove)
            string nombre = found.Name.Remove(found.Name.LastIndexOf(found.Extension));

            // Escritura del archivo .csv con los campos correspondientes 
            hoja.WriteLine(i + "," + nombre + "," + found.Extension);
        }
        hoja.Close();
    }
}