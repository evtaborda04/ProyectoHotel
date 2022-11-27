using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logica
{
    internal class TemaColores
    {
        //public static ConsoleColor PanelPadre;
        //public static ConsoleColor PanelBotones;
        //public static ConsoleColor BarraTitulo;
        //public static ConsoleColor TextBusqueda;
        //public static ConsoleColor FuenteIconos;


        ////Colores Defecto
        //private static readonly ConsoleColor PanelPadreD = ConsoleColor.FromArgb(59, 17, 27);
        //private static readonly ConsoleColor PanelBotonesD = ConsoleColor.FromArgb(122, 35, 56);
        //private static readonly ConsoleColor BarraTituloD = ConsoleColor.FromArgb(186, 54, 85);
        //private static readonly ConsoleColor TextBusquedaD = ConsoleColor.FromArgb(250, 73, 115);
        //private static readonly ConsoleColor FuenteIconosD = ConsoleColor.White;

        ////Tema Morado
        //private static readonly ConsoleColor PanelPadreM = ConsoleColor.FromArgb(92, 36, 97);
        //private static readonly ConsoleColor PanelBotonesM = ConsoleColor.FromArgb(94, 65, 97);
        //private static readonly ConsoleColor BarraTituloM = ConsoleColor.FromArgb(164, 64, 173);
        //private static readonly ConsoleColor TextBusquedaM = ConsoleColor.FromArgb(223, 154, 230);
        //private static readonly ConsoleColor FuenteIconosM = ConsoleColor.White;

        ////Tema Verde
        //private static readonly ConsoleColor PanelPadreV = ConsoleColor.FromArgb(71, 102, 0);
        //private static readonly ConsoleColor PanelBotonesV = ConsoleColor.FromArgb(121, 173, 0);
        //private static readonly ConsoleColor BarraTituloV = ConsoleColor.FromArgb(157, 224, 0);
        //private static readonly ConsoleColor TextBusquedaV = ConsoleColor.FromArgb(181, 230, 63);
        //private static readonly ConsoleColor FuenteIconosV = ConsoleColor.White;

        ////Tema Celeste
        //private static readonly ConsoleColor PanelPadreC = ConsoleColor.FromArgb(35, 94, 97);
        //private static readonly ConsoleColor PanelBotonesC = ConsoleColor.FromArgb(74, 101, 102);
        //private static readonly ConsoleColor BarraTituloC = ConsoleColor.FromArgb(115, 156, 158);
        //private static readonly ConsoleColor TextBusquedaC = ConsoleColor.FromArgb(164, 221, 224);
        //private static readonly ConsoleColor FuenteIconosC = ConsoleColor.White;

        ////Tema Acua
        //private static readonly ConsoleColor PanelPadreA = ConsoleColor.FromArgb(17, 47, 51);
        //private static readonly ConsoleColor PanelBotonesA = ConsoleColor.FromArgb(33, 92, 99);
        //private static readonly ConsoleColor BarraTituloA = ConsoleColor.FromArgb(37, 115, 125);
        //private static readonly ConsoleColor TextBusquedaA = ConsoleColor.FromArgb(58, 162, 176);
        //private static readonly ConsoleColor FuenteIconosA = ConsoleColor.White;

        ////Tema Naranja
        //private static readonly ConsoleColor PanelPadreN = ConsoleColor.FromArgb(51, 35, 3);
        //private static readonly ConsoleColor PanelBotonesN = ConsoleColor.FromArgb(99, 68, 6);
        //private static readonly ConsoleColor BarraTituloN = ConsoleColor.FromArgb(125, 85, 4);
        //private static readonly ConsoleColor TextBusquedaN = ConsoleColor.FromArgb(181, 124, 11);
        //private static readonly ConsoleColor FuenteIconosN = ConsoleColor.White;

        ////tema Blue
        //private static readonly ConsoleColor PanelPadreB = ConsoleColor.FromArgb(15, 6, 51);
        //private static readonly ConsoleColor PanelBotonesB = ConsoleColor.FromArgb(30, 11, 99);
        //private static readonly ConsoleColor BarraTituloB = ConsoleColor.FromArgb(35, 10, 125);
        //private static readonly ConsoleColor TextBusquedaB = ConsoleColor.FromArgb(55, 20, 179);
        //private static readonly ConsoleColor FuenteIconosB = ConsoleColor.White;

        ////SeleccionarColores
        //public static void ElegirTema(string Tema)
        //{
        //    if (Tema == "Defecto")
        //    {
        //        PanelPadre = PanelPadreD;
        //        PanelBotones = PanelBotonesD;
        //        BarraTitulo = BarraTituloD;
        //        TextBusqueda = TextBusquedaD;
        //        FuenteIconos = FuenteIconosD;
        //    }
        //    if (Tema == "Morado")
        //    {
        //        PanelPadre = PanelPadreM;
        //        PanelBotones = PanelBotonesM;
        //        BarraTitulo = BarraTituloM;
        //        TextBusqueda = TextBusquedaM;
        //        FuenteIconos = FuenteIconosM;
        //    }
        //    if (Tema == "Verde")
        //    {
        //        PanelPadre = PanelPadreV;
        //        PanelBotones = PanelBotonesV;
        //        BarraTitulo = BarraTituloV;
        //        TextBusqueda = TextBusquedaV;
        //        FuenteIconos = FuenteIconosV;
        //    }
        //    if (Tema == "Celeste")
        //    {
        //        PanelPadre = PanelPadreC;
        //        PanelBotones = PanelBotonesC;
        //        BarraTitulo = BarraTituloC;
        //        TextBusqueda = TextBusquedaC;
        //        FuenteIconos = FuenteIconosC;
        //    }
        //    if (Tema == "Acua")
        //    {
        //        PanelPadre = PanelPadreA;
        //        PanelBotones = PanelBotonesA;
        //        BarraTitulo = BarraTituloA;
        //        TextBusqueda = TextBusquedaA;
        //        FuenteIconos = FuenteIconosA;
        //    }

        //    if (Tema == "Naranja")
        //    {
        //        PanelPadre = PanelPadreN;
        //        PanelBotones = PanelBotonesN;
        //        BarraTitulo = BarraTituloN;
        //        TextBusqueda = TextBusquedaN;
        //        FuenteIconos = FuenteIconosN;
        //    }

        //    if (Tema == "Azul")
        //    {
        //        PanelPadre = PanelPadreB;
        //        PanelBotones = PanelBotonesB;
        //        BarraTitulo = BarraTituloB;
        //        TextBusqueda = TextBusquedaB;
        //        FuenteIconos = FuenteIconosB;
        //    }
        //}
    }
}
