namespace espacioTareas;

public class Tareas {
    private int _id;
    private string? _desc;
    private int _duracion;
    public int Id{
        get{
            return _id;
        }
    }
    public string? Desc{
        get{
            return _desc;
        }
    }
    public int Duracion{
        get{
            return _duracion;
        }
    }


    public Tareas (int id, string desc, int duracion){
        _id = id;
        _desc = desc;
        _duracion = duracion;
    }
}