using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace SAM_tecnicas
{
    public partial class SECUNDARIO : Form
    {
        List<requerimiento> requerimientos = new List<requerimiento>();

        public SECUNDARIO()
        {
            InitializeComponent();
        }

        private void SECUNDARIO_Load(object sender, EventArgs e)
        {
            marca.Text = "";
            modelo.Text = "";
            alto.Text = "";
            ancho.Text = "";
            largo.Text = "";
            voltaje.Text = "";
            corriente.Text = "";
            potencia.Text = "";
            medio.Text = "";
            funcion.Text = "";
            color.Text = "";
            fabricante.Text = "";
            ph.Text = "";

            requerimientos.Add(new requerimiento
            {
                nombre = "Prensa Hidraulica ",
                codigo = "INSTR-1",
                inspeccion = "Inspección General de Prensas Mecaicas ",
                material_ne = "Paño seco,	LLaves para ajuste de pernos,	Aceite",
                instructivo1 = "1) Compruebe si hay fugas de aceite en todas las líneas hidráulicas,Apriete los racores con fugas y limpie el exceso de aceite.  ",
                instructivo2 = "2) Compruebe el nivel de aceite y, si es necesario, rellénelo.",
                instructivo3 = "3) Compruebe si hay pernos sueltos alrededor del área de herramientas.",
                instructivo4 = "4) Compruebe la lubricación de los platos guiados, No engrase demasiado",
                tiempo = 4
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Motores trifasico Asincrono ",
                codigo = "INSTR-2",
                inspeccion= "Inspeccion General Bandas Tranportadoras",
                material_ne = "LLaves, Tuercas y Pernos, 	Aciete, 	Multimetro, 	Tester",
                instructivo1 = "1) Revise la alineación y si hay desgaste en la bandeja",
                instructivo2 = "2) Apriete todos los pernos según las especificaciones de apriete del fabricante. ",
                instructivo3 = "3)Revise si hay desgaste en la poleas ",
                instructivo4 = "4) Revise los bordes en busca de desgaste o daño. ",
                tiempo = 4
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Motores trifasico Asincrono ",
                codigo = "INSTR-2",
                inspeccion = "Inspeccion General Bandas Tranportadoras",
                material_ne = "LLaves, Tuercas y Pernos, 	Aciete, 	Multimetro, 	Tester",
                instructivo1 = "1) Revise la alineación y si hay desgaste en la bandeja",
                instructivo2 = "2) Apriete todos los pernos según las especificaciones de apriete del fabricante. ",
                instructivo3 = "3)Revise si hay desgaste en la poleas ",
                instructivo4 = "4) Revise los bordes en busca de desgaste o daño. ",
                tiempo = 4
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Banda Transportadora ",
                codigo = "INSTR-3",
                inspeccion = "Inspeccion General Bandas Tranportadoras",
                material_ne = "LLaves, Tuercas y Pernos, 	Aciete, 	Multimetro, 	Tester",
                instructivo1 = "1) Revise la alineación y si hay desgaste en la bandeja",
                instructivo2 = "2) Apriete todos los pernos según las especificaciones de apriete del fabricante. ",
                instructivo3 = "3)Revise si hay desgaste en la poleas ",
                instructivo4 = "4) Revise los bordes en busca de desgaste o daño. ",
                tiempo = 5
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Sistema de Refrigeración ",
                codigo = "INSTR-4",
                inspeccion = "Inspección General Sistemas de Rrefrigeración ",
                material_ne = "LLaves, 	Repuestos de Rodaientos, 	Repuestos de Correas, 	Paño seco ",
                instructivo1 = "1) Inspeccione los rodamientos en busca de desgaste y deterioro. Reemplácelos si es necesario.",
                instructivo2 = "2)Revise si las correas están desgastadas y reemplace las que estén rasgadas o desgastadas.",
                instructivo3 = "3) Compruebe que los pernos y los tornillos de fijación estén bien ajustados. Ajústelos según sea necesario",
                instructivo4 = "4) Inspeccione el motor para ver si está limpio. Solo limpie las superficies exteriores. Quite el polvo y la grasa de la carcasa del motor para garantizar un enfriamiento apropiado. ",
                tiempo = 2
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Robot Industrial (Robot Industrial)",
                codigo = "INSTR-5",
                inspeccion = "Inspección General Sistemas de Robots Industriales",
                material_ne = "Computador, 	Destornillador, Aceite,	Multimetro",
                instructivo1 = "1) Inspección de la condición del robot, lo que incluye arnés interno, fuelles, forros, cables, ventiladores de refrigeración, fuentes de alimentación y baterías.",
                instructivo2 = "2) Prueba del funcionamiento de parada de emergencia, interbloqueo, consola portátil y manual.",
                instructivo3 = "3) Prueba del freno en caso de deslizamiento",
                instructivo4 = "4) Revisión de sonido o ruido de vibración excesivo.",
                tiempo = 2
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Variador de Velocidad ",
                codigo = "INSTR-6",
                inspeccion = "Inspección General Variadores de velocidad ",
                material_ne = "Destornilladores Plano y estrella, 	Multimetro,  	Fuente Regulable 24 Vdc	Alicante de Punta y Corte,	Cinta Aislante, 	Barniz acrilico",
                instructivo1 = "1) Verifique que el panel de control este operativo ",
                instructivo2 = "2) Apagar el equipo",
                instructivo3 = "3) Revisar las placas electrónicas si alguna está dañada odeformada.",
                instructivo4 = "4) Resoldar puntos de soldadurafría según criterio del técnicoelectrónico   ya   sea   por   elcambio de color o grietas de lasoldadura",
                tiempo = 48
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Maquina de Corte ",
                codigo = "INSTR-7",
                inspeccion = "Inspección General Maquina de Corte ",
                material_ne = "Multimetro, 	Aceite,	Tacometro,	Osciloscopio, 	Fuente Dc",
                instructivo1 = "1) Engrasar rodamientos y realizar analisis de vibraciones ",
                instructivo2 = "2) Revisión y Limpieza de motor Electrico ",
                instructivo3 = "3)Revisión General de Caja de Velocidades ",
                instructivo4 = "4) Revisión General de sistema electrico (Reles, sensores señales,conductores ,bobinas )",
                tiempo = 2
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Taladradoras Verticales",
                codigo = "INSTR-8",
                inspeccion = "Inspección General Maquinas Taladradoras",
                material_ne = "Escobilla y Trapos de limpieza, Aceite",
                instructivo1 = "1)Eliminar las virutas y restos de medios refrigerantes",
                instructivo2 = "2) Raspar las ranuras de la mesa con una lamina apropiada para ello.",
                instructivo3 = "3) Las piezas bruñidas de la maquina como por ejemplo el husillo de taladrado, las manecillas de mando, se deben limpiar y lubricar levemente.",
                instructivo4 = "4) Limpiar el filtro de la bomba de refrigerante así como el depósito de refrigerante.",
                tiempo = 6
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Controladores PLC",
                codigo = "INSTR-9",
                inspeccion = "Inspección General de Controladores PLC",
                material_ne = "Multimetro, 	Osciloscopio, 	Cepillo para polvo, 	paño seco,	Soldadura",
                instructivo1 = "1) Comprobar que la temperatura del entorno, la humedad y otros factores satisfacen las condiciones de funcionamiento del PLC",
                instructivo2 = "2) Desconectar el autómata programable. Durante el mantenimiento, las conexiones siempre deben ser revisadas con la máquina apagada.",
                instructivo3 = "3) Cualquier filtro que haya sido instalado en los recintos debe ser limpiado o reemplazado para asegurar que haya una circulación de aire limpio dentro del recinto.",
                instructivo4 = "4) Las tarjetas de circuito que se ocupan de los procesos de control analógico deben calibrarse cada 6 meses. Otros dispositivos, como los sensores, deben recibir servicio mensualmente",
                tiempo = 5
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Servo Motor ",
                codigo = "INSTR-10",
                inspeccion = "Inspección general de Servo Motores",
                material_ne = "Llaves Para rodamientos, 	Destornillador, 	Fuente DC 24 Vdc,	Multimetro	Osciloscopio ",
                instructivo1 = "1) Inspección de entrada del motor y toma de datos en banco de pruebas. ",
                instructivo2 = "2) Verificación del elemento de captación (codificador)…… resolver, sonda hall, encoder, etc",
                instructivo3 = "3) Control de conectores.",
                instructivo4 = "4) Análisis de rodamientos, se cambian sistemáticamente.",
                tiempo = 5
            });

            requerimientos.Add(new requerimiento
            {
                nombre = "Robots de Soldadura",
                codigo = "INSTR-11",
                inspeccion = "Inspección General de Robots de soldaura",
                material_ne = "Juego de LLaves, 	Destornilladore Electrico,	Repuesto Boquillas de soldadura	",
                instructivo1 = "1) Reemplace el revestimiento de soldadura semanalmente ",
                instructivo2 = "2) observe cómo el robot recorre la aplicación y tome nota de los cables que se arrastran, frotan, tocan abrazaderas o se mueven a lo largo de cualquier otra parte de la celda o sistema de soldadura.",
                instructivo3 = "3)Revise las puntas y las boquillas de las  pistolas de soldadura: las puntas de las pistolas de soldadura deben reemplazarse a diario y la boquilla debe revisarse para detectar salpicaduras de soldadura",
                instructivo4 = "",
                tiempo = 1
            });
        }

        private void Consulta_ri_Click(object sender, EventArgs e)
        {
            int num = requerimientos.FindIndex(x => x.nombre == comboBox1.SelectedItem.ToString());
            codigo.Text = requerimientos[num].codigo;
            material.Text = requerimientos[num].material_ne;
            inspeccion.Text = requerimientos[num].inspeccion;
            instrucutivo.Text = requerimientos[num].instructivo1;
            instructivo1.Text = requerimientos[num].instructivo2;
            instructivo2.Text = requerimientos[num].instructivo3;
            instructivo3.Text = requerimientos[num].instructivo4;
            tiempo.Text = requerimientos[num].tiempo.ToString()+" horas";

            codigo.Visible = true;
            material.Visible = true;
            inspeccion.Visible = true;
            instructivo1.Visible = true;
            instructivo2.Visible = true;
            instructivo3.Visible = true;
            instrucutivo.Visible = true;
            tiempo.Visible = true;
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            marca.Text ="MARCA: ";
            modelo.Text = "MODELO: ";
            alto.Text = "ALTO: ";
            ancho.Text = "ANCHO: ";
            largo.Text = "LARGO: ";
            voltaje.Text = "VOLTAJE: ";
            corriente.Text = "CORRIENTE: ";
            potencia.Text = "POTENCIA: ";
            medio.Text = "MEDIO: ";
            funcion.Text = "FINCIÓN: ";
            color.Text = "COLOR: ";
            fabricante.Text = "FABRICANTE: ";
            ph.Text = "PH-cos(): ";
            seccion.Text = "SECCIÓN: ";

            fi.Visible = false;
            trabajo.Visible = false;
            ff.Visible = false;
            mante.Visible = false;
            operario.Visible = false;
            insumos.Visible = false;
            obs.Visible = false;

            nombreHV.Text = nombreHV.Text + tarjetahoja.SelectedItem.ToString();
            try
            {
                using (var contex = new MantenimientoEntities1())
                {
                    var tarjeta = contex.tarjeta.ToList();
                    var hv = contex.hv.ToList();
                    int num = tarjeta.FindIndex(x => x.nombre == tarjetahoja.Text);
                    int num1 = hv.FindIndex(x => x.nombre == tarjetahoja.Text);
                    if (num >= 0)
                    {
                        marca.Text += tarjeta[num].marca;
                        modelo.Text += tarjeta[num].modelo;
                        alto.Text += tarjeta[num].alto;
                        ancho.Text += tarjeta[num].ancho;
                        largo.Text += tarjeta[num].largo;
                        voltaje.Text += tarjeta[num].voltaje;
                        corriente.Text += tarjeta[num].corriente;
                        potencia.Text += tarjeta[num].potencia;
                        medio.Text += tarjeta[num].medios;
                        funcion.Text += tarjeta[num].funcion;
                        color.Text += tarjeta[num].color;
                        fabricante.Text += tarjeta[num].fabricante;
                        ph.Text += tarjeta[num].ph;
                        seccion.Text += tarjeta[num].seccion;
                        fi.Text = hv[num1].fi.ToString("MM/dd/yyyy");
                        fi.Visible = true;
                        trabajo.Text = hv[num1].trabajo;
                        trabajo.Visible = true;
                        ff.Text = hv[num1].ff.ToString("MM/dd/yyyy");
                        ff.Visible = true;
                        mante.Text = hv[num1].mante;
                        mante.Visible = true;
                        operario.Text = hv[num1].operario;
                        operario.Visible = true;
                        insumos.Text = hv[num1].insumos;
                        insumos.Visible = true;
                        obs.Text = hv[num1].observa;
                        obs.Visible = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            principal principal = new principal();
            principal.Visible = true;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            principal principal = new principal();
            principal.Visible = true;
            Visible = false;
        }
        private void M_OT_Click(object sender, EventArgs e)
        {
            OT_mto.Rows.Clear();
            try
            {
                using (var contex = new MantenimientoEntities1())
                {
                    var OT = contex.orden.ToList();
                    if (OT.Count > 0)
                    {
                        for (int i = 0; i < OT.Count; i++)
                        {
                            OT_mto.Rows.Add(OT[i].id,
                                OT[i].empresa,
                                OT[i].edificio,
                                OT[i].area,
                                OT[i].local,
                                OT[i].fechaini,
                                OT[i].fechafi,
                                OT[i].descripcion,
                                OT[i].Necco,
                                OT[i].recursos,
                                OT[i].prioridad,
                                OT[i].mto,
                                OT[i].nombre_t,
                                OT[i].material,
                                OT[i].cantida,
                                OT[i].Pu.ToString(),
                                OT[i].importe.ToString(),
                                OT[i].duracion,
                                OT[i].costohh.ToString(),
                                OT[i].importeHH.ToString(),
                                OT[i].indicadores,
                                OT[i].observaciones,
                                OT[i].evaluacion,
                                OT[i].causa,
                                OT[i].recibido
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void AgregaOT_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contex = new MantenimientoEntities1())
                {
                    contex.orden.Add(new orden {
                        empresa = emp.Text,
                        edificio = edi.Text,
                        area = are.Text,
                        local = loc.Text,
                        fechaini = fei.Text,
                        fechafi = fef.Text,
                        descripcion = des.Text,
                        Necco = necc.Text,
                        recursos = rec.Text,
                        prioridad = pri.Text,
                        mto = tip.Text,
                        nombre_t = nom.Text,
                        material = mat.Text,
                        cantida = can.Text,
                        Pu = int.Parse(pru.Text),
                        importe = int.Parse(imp.Text),
                        duracion = dur.Text,
                        costohh = int.Parse(cos.Text),
                        importeHH = int.Parse(imh.Text),
                        indicadores = ind.Text,
                        observaciones=obser.Text,
                        evaluacion = eva.Text,
                        causa = cau.Text,
                        recibido = reci.Text });
                    contex.SaveChanges();
                }
                emp.Text = "";
                edi.Text = "";
                are.Text = "";
                loc.Text = "";
                fei.Text = "";
                fef.Text = "";
                des.Text = "";
                necc.Text = "";
                rec.Text = "";
                pri.Text = "";
                tip.Text = "";
                nom.Text = "";
                mat.Text = "";
                can.Text = "";
                pru.Text = "";
                imp.Text = "";
                ind.Text = "";
                obser.Text = "";
                eva.Text = "";
                cau.Text = "";
                reci.Text = "";
                dur.Text = "";
                cos.Text = "";
                imh.Text = "";
                MessageBox.Show("Se agrego correctamente la orden");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Descarga_Click(object sender, EventArgs e)
        {

            try
            {
                using (var contex = new MantenimientoEntities1())
                {
                    var OT = contex.orden.ToList();
                    int i = Convert.ToInt32(numeroDes.Text);
                    if (i <= OT.Count)
                    {
                        i = i - 1;
                        OT_mto.Rows.Clear();
                        OT_mto.Rows.Add(OT[i].id,
                                OT[i].empresa, 
                                OT[i].edificio,
                                OT[i].area, 
                                OT[i].local,
                                OT[i].fechaini,
                                OT[i].fechafi,
                                OT[i].descripcion,
                                OT[i].Necco,
                                OT[i].recursos,
                                OT[i].prioridad,
                                OT[i].mto,
                                OT[i].nombre_t,
                                OT[i].material,
                                OT[i].cantida,
                                OT[i].Pu.ToString(),
                                OT[i].importe.ToString(),
                                OT[i].duracion,
                                OT[i].costohh.ToString(),
                                OT[i].importeHH.ToString(),
                                OT[i].indicadores,
                                OT[i].observaciones,
                                OT[i].evaluacion,
                                OT[i].causa,
                                OT[i].recibido);
                        DataTable dt = new DataTable();
                        System.IO.FileStream fs = new System.IO.FileStream(OT[i].empresa+"_"+OT[i].id.ToString()+".pdf", System.IO.FileMode.Create);
                        Document document = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                        dt = (DataTable)OT_mto.DataSource;

                        document.Open();

                        //Tabla 1
                        PdfPTable table = new PdfPTable(4);
                        ///titulo tabla
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA,BaseFont.CP1252,BaseFont.EMBEDDED);
                        Font font = new Font(bf, 20, 0, BaseColor.DARK_GRAY);
                        PdfPCell cell = new PdfPCell(new Phrase("ORDEN DE TRABAJO NÚMERO: "+OT[i].id.ToString(),font));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253,151,3);
                        table.AddCell(cell);
                        //----empresa
                        cell = new PdfPCell(new Phrase("Empresa"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table.AddCell(cell);
                        table.AddCell(OT[i].empresa);
                        //-------fecha inicial
                        cell = new PdfPCell(new Phrase("Fecha inicial"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table.AddCell(cell);
                        table.AddCell(OT[i].fechafi);
                        //----edificio
                        cell = new PdfPCell(new Phrase("Edificio"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table.AddCell(cell);
                        table.AddCell(OT[i].edificio);
                        //-------fecha final
                        cell = new PdfPCell(new Phrase("Fecha final"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table.AddCell(cell);
                        table.AddCell(OT[i].fechafi);
                        //-------area
                        cell = new PdfPCell(new Phrase("Area"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table.AddCell(cell);
                        table.AddCell(OT[i].area);
                        //-------local
                        cell = new PdfPCell(new Phrase("Local"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table.AddCell(cell);
                        table.AddCell(OT[i].local);
                        document.Add(table);

                        //TABLA 2
                        PdfPTable table2 = new PdfPTable(1);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("DESCRIPCIÓN DEL SERVICIO DE MANTENIMIENTO", font));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table2.AddCell(cell);
                        table2.AddCell(OT[i].descripcion);
                        document.Add(table2);


                        Paragraph saltoDeLinea = new Paragraph("                                        ");
                        document.Add(saltoDeLinea);
                        //TABLA 3
                        PdfPTable table3 = new PdfPTable(4);
                        //----No ecco
                        cell = new PdfPCell(new Phrase("No. Ecco"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table3.AddCell(cell);
                        table3.AddCell(OT[i].Necco);
                        //-------prioridad
                        cell = new PdfPCell(new Phrase("Prioridad"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table3.AddCell(cell);
                        table3.AddCell(OT[i].prioridad);
                        //----Recursos
                        cell = new PdfPCell(new Phrase("Recursos"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table3.AddCell(cell);
                        table3.AddCell(OT[i].recursos);
                        //-------Tipo mto
                        cell = new PdfPCell(new Phrase("Tipo de mantenimiento"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table3.AddCell(cell);
                        table3.AddCell(OT[i].mto);
                        document.Add(table3);

                        //Tabla 4
                        PdfPTable table4 = new PdfPTable(2);
                        //----nombre
                        cell = new PdfPCell(new Phrase("Nombre del técnico y/o contratista"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table4.AddCell(cell);
                        table4.AddCell(OT[i].nombre_t);
                        document.Add(table4);
                        //Tabla 5
                        PdfPTable table5 = new PdfPTable(4);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("MATERIALES Y/O REFACCIONES", font));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Concepto"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Cantidad"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("P.U."));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Importe"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        table5.AddCell(OT[i].material);
                        table5.AddCell(OT[i].cantida);
                        table5.AddCell(OT[i].Pu.ToString());
                        table5.AddCell(OT[i].importe.ToString());
                        cell = new PdfPCell(new Phrase("Costo total materiales", font));
                        cell.Colspan = 3;
                        table5.AddCell(cell);
                        table5.AddCell((OT[i].Pu*int.Parse(OT[i].cantida) + OT[i].importe).ToString());
                        document.Add(table5);

                        //TABLA 6
                        table5 = new PdfPTable(3);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("REGISTRO DE TIEMPO", font));
                        cell.Colspan = 3;
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Duración"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Costo HH"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Importe"));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(143, 253, 3);
                        table5.AddCell(cell);
                        table5.AddCell(OT[i].duracion);
                        table5.AddCell(OT[i].costohh.ToString());
                        table5.AddCell(OT[i].importeHH.ToString());
                        cell = new PdfPCell(new Phrase("Costo total de mano de obra", font));
                        cell.Colspan = 2;
                        table5.AddCell(cell);
                        table5.AddCell((OT[i].costohh*int.Parse(OT[i].duracion) + OT[i].importeHH).ToString());
                        cell = new PdfPCell(new Phrase("Costo total de materiales y mano de obra", font));
                        cell.Colspan = 2;
                        table5.AddCell(cell);
                        table5.AddCell((OT[i].costohh * int.Parse(OT[i].duracion) + OT[i].importeHH + OT[i].Pu * int.Parse(OT[i].cantida) + OT[i].importe).ToString());
                        document.Add(table5);


                        saltoDeLinea = new Paragraph("                                        ");
                        document.Add(saltoDeLinea);
                        //Tabla 7
                        table2 = new PdfPTable(1);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("INDICACIONES DE SEGURIDAD", font));
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table2.AddCell(cell);
                        table2.AddCell(OT[i].indicadores);
                        document.Add(table2);
                        //tabla 8
                        table2 = new PdfPTable(1);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("OBSERVACIONES", font));
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table2.AddCell(cell);
                        table2.AddCell(" "+OT[i].observaciones);
                        document.Add(table2);
                        //tabla 9
                        table2 = new PdfPTable(1);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("EVALUACIÓN DEL SERVICIO", font));
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table2.AddCell(cell);
                        cell = new PdfPCell(new Phrase(OT[i].evaluacion));
                        cell.HorizontalAlignment = 1;
                        table2.AddCell(cell);
                        document.Add(table2);
                        //tabla 10
                        table2 = new PdfPTable(1);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("RECIBO DE CONFORMIDAD", font));
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table2.AddCell(cell);
                        document.Add(table2);
                        table2 = new PdfPTable(2);
                        table2.AddCell(new Phrase("Nombre"));
                        cell = new PdfPCell(new Phrase(OT[i].recibido));
                        cell.HorizontalAlignment = 1;
                        table2.AddCell(cell);
                        document.Add(table2);
                        //tabla 11
                        table2 = new PdfPTable(1);
                        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
                        font = new Font(bf, 10, 0, BaseColor.DARK_GRAY);
                        cell = new PdfPCell(new Phrase("CAUSA DE LA FALLA", font));
                        cell.HorizontalAlignment = 1;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(253, 151, 3);
                        table2.AddCell(cell);
                        cell = new PdfPCell(new Phrase(OT[i].causa));
                        cell.HorizontalAlignment = 1;
                        table2.AddCell(cell);
                        document.Add(table2);

                        saltoDeLinea = new Paragraph("                                        ");
                        document.Add(saltoDeLinea);
                        document.Add(new Paragraph("_________________________"));
                        document.Add(new Paragraph("Firma: "+ OT[i].nombre_t));
                        saltoDeLinea = new Paragraph("                                        ");
                        document.Add(saltoDeLinea);
                        document.Add(new Paragraph("_________________________"));
                        document.Add(new Paragraph("Firma: " + OT[i].recibido));


                        document.Close();
                        writer.Close();
                        fs.Close();
                        MessageBox.Show("El archivo se descargo y se encuentra en la carpeta de la aplicación");
                    }
                    else
                    {
                        MessageBox.Show("Ese indice no existe");
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void NumeroDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                MessageBox.Show("Solo se aceptan numeros");
                e.Handled = true;
                return;
            }
                
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            principal principal = new principal();
            principal.Visible = true;
            Visible = false;
        }

    }
    class requerimiento
    {
        public string nombre;
        public string codigo;
        public string material_ne;
        public string inspeccion;
        public string instructivo1;
        public string instructivo2;
        public string instructivo3;
        public string instructivo4;
        public int tiempo;
    }
}
