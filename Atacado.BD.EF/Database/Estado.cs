namespace Atacado.BD.EF.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Estado")]
public partial class Estado
{
    [Key]

    public Int64 CodigoEstado {get; set;}
    public Int64 CodigoRegiao {get; set;}

    [Unicode(false)]
    public string UF {get; set;} = null!;

    [Unicode(false)]
    public string Nome {get; set;} = null!;

    public Estado(){}
}

