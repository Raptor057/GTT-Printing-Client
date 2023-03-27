using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Design;
using static GT.Trace.Labels.Templates.UseCases.PrintingRequest;

namespace GT.Trace.PrintingCompanion
{
    public class PrintingConfiguration : Component
    {
        public sealed class Configuration
        {
            private readonly PrintRequestTypes _request;

            public Configuration(PrintRequestTypes request)
            {
                _request = request;
            }

            public string PrinterName
            {
                get
                {
                    switch (_request)
                    {
                        case PrintRequestTypes.JrLabel:
                            return Properties.Settings.Default.JrLabelPrinterName;

                        case PrintRequestTypes.MasterLabel:
                            return Properties.Settings.Default.MasterLabelPrinterName;

                        case PrintRequestTypes.MaterialReturnLabel:
                            return Properties.Settings.Default.MaterialReturnsPrinterName;

                        case PrintRequestTypes.PickingLabel:
                            return Properties.Settings.Default.PickingLabelPrinterName;

                        case PrintRequestTypes.SubAssemblyEti:
                            return Properties.Settings.Default.SubAssemblyEtiPrinterName;

                        case PrintRequestTypes.WipLabel:
                            return Properties.Settings.Default.WipLabelPrinterName;

                        default:
                            throw new InvalidEnumArgumentException();
                    }
                }
            }

            public int TotalCopies
            {
                get
                {
                    switch (_request)
                    {
                        case PrintRequestTypes.JrLabel:
                            return Properties.Settings.Default.JrLabelCopies;

                        case PrintRequestTypes.MasterLabel:
                            return Properties.Settings.Default.MasterLabelCopies;

                        case PrintRequestTypes.MaterialReturnLabel:
                            return Properties.Settings.Default.MaterialReturnsCopies;

                        case PrintRequestTypes.PickingLabel:
                            return Properties.Settings.Default.PickingLabelCopies;

                        case PrintRequestTypes.SubAssemblyEti:
                            return Properties.Settings.Default.SubAssemblyEtiCopies;

                        case PrintRequestTypes.WipLabel:
                            return Properties.Settings.Default.WipLabelCopies;

                        default:
                            throw new InvalidEnumArgumentException();
                    }
                }
            }
        }

        public Configuration this[PrintRequestTypes requestType] => new Configuration(requestType);

        [Editor(typeof(PrinterNameEditor), typeof(UITypeEditor))]
        [DisplayName("Nombre de Impresora")]
        [Category("Retorno de Material"), Description("Nombre de la impresora a utilizar para imprimir etiquetas de retorno de material.")]
        public PrinterName MaterialReturnsPrinterName
        {
            get
            {
                return new PrinterName(Properties.Settings.Default.MaterialReturnsPrinterName);
            }
            set
            {
                Properties.Settings.Default.MaterialReturnsPrinterName = value?.Value;
                Properties.Settings.Default.Save();
            }
        }

        [DisplayName("Cantidad de Copias")]
        [Category("Retorno de Material"), Description("Cantidad de copias a imprimir de etiquetas de retorno de material.")]
        public int MaterialReturnsCopies
        {
            get
            {
                return Properties.Settings.Default.MaterialReturnsCopies;
            }
            set
            {
                if (Properties.Settings.Default.MaterialReturnsCopies != value && 1 <= value && value <= 3)
                {
                    Properties.Settings.Default.MaterialReturnsCopies = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        [Editor(typeof(PrinterNameEditor), typeof(UITypeEditor))]
        [DisplayName("Nombre de Impresora")]
        [Category("Sub Ensamble"), Description("Nombre de la impresora a utilizar para imprimir etiquetas de sub ensamble.")]
        public PrinterName SubAssemblyEtiPrinterName
        {
            get
            {
                return new PrinterName(Properties.Settings.Default.SubAssemblyEtiPrinterName);
            }
            set
            {
                Properties.Settings.Default.SubAssemblyEtiPrinterName = value?.Value;
                Properties.Settings.Default.Save();
            }
        }

        [DisplayName("Cantidad de Copias")]
        [Category("Sub Ensamble"), Description("Cantidad de copias a imprimir de etiquetas de sub ensamble.")]
        public int SubAssemblyEtiCopies
        {
            get
            {
                return Properties.Settings.Default.SubAssemblyEtiCopies;
            }
            set
            {
                if (Properties.Settings.Default.SubAssemblyEtiCopies != value && 1 <= value && value <= 3)
                {
                    Properties.Settings.Default.SubAssemblyEtiCopies = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        [Editor(typeof(PrinterNameEditor), typeof(UITypeEditor))]
        [DisplayName("Nombre de Impresora")]
        [Category("Master"), Description("Nombre de la impresora a utilizar para imprimir etiquetas master.")]
        public PrinterName MasterLabelPrinterName
        {
            get
            {
                return new PrinterName(Properties.Settings.Default.MasterLabelPrinterName);
            }
            set
            {
                Properties.Settings.Default.MasterLabelPrinterName = value?.Value;
                Properties.Settings.Default.Save();
            }
        }

        [DisplayName("Cantidad de Copias")]
        [Category("Master"), Description("Cantidad de copias a imprimir de etiquetas master.")]
        public int MasterLabelCopies
        {
            get
            {
                return Properties.Settings.Default.MasterLabelCopies;
            }
            set
            {
                if (Properties.Settings.Default.MasterLabelCopies != value && 1 <= value && value <= 3)
                {
                    Properties.Settings.Default.MasterLabelCopies = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        [Editor(typeof(PrinterNameEditor), typeof(UITypeEditor))]
        [DisplayName("Nombre de Impresora")]
        [Category("Junior"), Description("Nombre de la impresora a utilizar para imprimir etiquetas junior.")]
        public PrinterName JrLabelPrinterName
        {
            get
            {
                return new PrinterName(Properties.Settings.Default.JrLabelPrinterName);
            }
            set
            {
                Properties.Settings.Default.JrLabelPrinterName = value?.Value;
                Properties.Settings.Default.Save();
            }
        }

        [DisplayName("Cantidad de Copias")]
        [Category("Junior"), Description("Cantidad de copias a imprimir de etiquetas junior.")]
        public int JrLabelCopies
        {
            get
            {
                return Properties.Settings.Default.JrLabelCopies;
            }
            set
            {
                if (Properties.Settings.Default.JrLabelCopies != value && 1 <= value && value <= 3)
                {
                    Properties.Settings.Default.JrLabelCopies = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        [Editor(typeof(PrinterNameEditor), typeof(UITypeEditor))]
        [DisplayName("Nombre de Impresora")]
        [Category("Picking"), Description("Nombre de la impresora a utilizar para imprimir etiquetas de picking de calidad.")]
        public PrinterName PickingLabelPrinterName
        {
            get
            {
                return new PrinterName(Properties.Settings.Default.PickingLabelPrinterName);
            }
            set
            {
                Properties.Settings.Default.PickingLabelPrinterName = value?.Value;
                Properties.Settings.Default.Save();
            }
        }

        [DisplayName("Cantidad de Copias")]
        [Category("Picking"), Description("Cantidad de copias a imprimir de etiquetas de picking de calidad.")]
        public int PickingLabelCopies
        {
            get
            {
                return Properties.Settings.Default.PickingLabelCopies;
            }
            set
            {
                if (Properties.Settings.Default.PickingLabelCopies != value && 1 <= value && value <= 3)
                {
                    Properties.Settings.Default.PickingLabelCopies = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        [Editor(typeof(PrinterNameEditor), typeof(UITypeEditor))]
        [DisplayName("Nombre de Impresora")]
        [Category("WIP"), Description("Nombre de la impresora a utilizar para imprimir etiquetas WIP.")]
        public PrinterName WipLabelPrinterName
        {
            get
            {
                return new PrinterName(Properties.Settings.Default.WipLabelPrinterName);
            }
            set
            {
                Properties.Settings.Default.WipLabelPrinterName = value?.Value;
                Properties.Settings.Default.Save();
            }
        }

        [DisplayName("Cantidad de Copias")]
        [Category("WIP"), Description("Cantidad de copias a imprimir de etiquetas WIP.")]
        public int WipLabelCopies
        {
            get
            {
                return Properties.Settings.Default.WipLabelCopies;
            }
            set
            {
                if (Properties.Settings.Default.WipLabelCopies != value && 1 <= value && value <= 3)
                {
                    Properties.Settings.Default.WipLabelCopies = value;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}