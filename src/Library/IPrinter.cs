//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintTicket(Recipe recipe);
    }
}

//Se usa el partón GRASP y el principio SOLID ya que las clases que implementen 
//IPrinter imprimirán el ticket sin importar el destino (File o Console)
