﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOS;

public class ReadFilmeDto
{
    public string Titulo { get; set; }

    public int Duracao { get; set; }

    public string Genero { get; set; }

    public DateTime HoraConsulta { get; set; } = DateTime.Now;
}
