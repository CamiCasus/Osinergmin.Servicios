//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace Osinergmin
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class Exception
    {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class parametro
    {
        
        private string codigoErrorField;
        
        private string codigoRecepcionField;
        
        private string codigoResultadoField;
        
        private string fechaProcesoField;
        
        private long numeroGuiaField;
        
        private bool numeroGuiaFieldSpecified;
        
        private int versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigoError
        {
            get
            {
                return this.codigoErrorField;
            }
            set
            {
                this.codigoErrorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigoRecepcion
        {
            get
            {
                return this.codigoRecepcionField;
            }
            set
            {
                this.codigoRecepcionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string codigoResultado
        {
            get
            {
                return this.codigoResultadoField;
            }
            set
            {
                this.codigoResultadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string fechaProceso
        {
            get
            {
                return this.fechaProcesoField;
            }
            set
            {
                this.fechaProcesoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public long numeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroGuiaSpecified
        {
            get
            {
                return this.numeroGuiaFieldSpecified;
            }
            set
            {
                this.numeroGuiaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class cabeceraMuestra
    {
        
        private string claveUsuarioField;
        
        private string codigoGuiaMuestrasField;
        
        private string comentarioField;
        
        private string fechaRecepcionLaboratorioField;
        
        private string guiaAdjuntaField;
        
        private string loginUsuarioField;
        
        private string nombreAdjuntoField;
        
        private string representanteLaboratorioField;
        
        private string representanteLaboratorioDniField;
        
        private string representanteOsinergminField;
        
        private string representanteOsinergminDniField;
        
        private string supervisorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string claveUsuario
        {
            get
            {
                return this.claveUsuarioField;
            }
            set
            {
                this.claveUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigoGuiaMuestras
        {
            get
            {
                return this.codigoGuiaMuestrasField;
            }
            set
            {
                this.codigoGuiaMuestrasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string comentario
        {
            get
            {
                return this.comentarioField;
            }
            set
            {
                this.comentarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string fechaRecepcionLaboratorio
        {
            get
            {
                return this.fechaRecepcionLaboratorioField;
            }
            set
            {
                this.fechaRecepcionLaboratorioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string guiaAdjunta
        {
            get
            {
                return this.guiaAdjuntaField;
            }
            set
            {
                this.guiaAdjuntaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string loginUsuario
        {
            get
            {
                return this.loginUsuarioField;
            }
            set
            {
                this.loginUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string nombreAdjunto
        {
            get
            {
                return this.nombreAdjuntoField;
            }
            set
            {
                this.nombreAdjuntoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string representanteLaboratorio
        {
            get
            {
                return this.representanteLaboratorioField;
            }
            set
            {
                this.representanteLaboratorioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string representanteLaboratorioDni
        {
            get
            {
                return this.representanteLaboratorioDniField;
            }
            set
            {
                this.representanteLaboratorioDniField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string representanteOsinergmin
        {
            get
            {
                return this.representanteOsinergminField;
            }
            set
            {
                this.representanteOsinergminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string representanteOsinergminDni
        {
            get
            {
                return this.representanteOsinergminDniField;
            }
            set
            {
                this.representanteOsinergminDniField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string supervisor
        {
            get
            {
                return this.supervisorField;
            }
            set
            {
                this.supervisorField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", ConfigurationName="Osinergmin.LabCalidadPortType")]
    public interface LabCalidadPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="registrarGuiaMuestrasAction", ReplyAction="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarGuiaMu" +
            "estrasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Osinergmin.Exception), Action="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarGuiaMu" +
            "estras/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Osinergmin.registrarGuiaMuestrasResponse> registrarGuiaMuestrasAsync(Osinergmin.registrarGuiaMuestrasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="registrarGuiaMuestrasDetalleAction", ReplyAction="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarGuiaMu" +
            "estrasDetalleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Osinergmin.Exception), Action="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarGuiaMu" +
            "estrasDetalle/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Osinergmin.registrarGuiaMuestrasDetalleResponse> registrarGuiaMuestrasDetalleAsync(Osinergmin.registrarGuiaMuestrasDetalleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="presentarGuiaMuestrasAction", ReplyAction="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/presentarGuiaMu" +
            "estrasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Osinergmin.Exception), Action="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/presentarGuiaMu" +
            "estras/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Osinergmin.presentarGuiaMuestrasResponse> presentarGuiaMuestrasAsync(Osinergmin.presentarGuiaMuestrasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="obtenerValidacionPorMuestraAction", ReplyAction="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/obtenerValidaci" +
            "onPorMuestraResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Osinergmin.Exception), Action="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/obtenerValidaci" +
            "onPorMuestra/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Osinergmin.obtenerValidacionPorMuestraResponse> obtenerValidacionPorMuestraAsync(Osinergmin.obtenerValidacionPorMuestraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="registrarInformeLabLiquidoCalidadAction", ReplyAction="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarInform" +
            "eLabLiquidoCalidadResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Osinergmin.Exception), Action="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarInform" +
            "eLabLiquidoCalidad/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Osinergmin.registrarInformeLabLiquidoCalidadResponse> registrarInformeLabLiquidoCalidadAsync(Osinergmin.registrarInformeLabLiquidoCalidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="registrarInformeLabGlpCalidadAction", ReplyAction="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarInform" +
            "eLabGlpCalidadResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Osinergmin.Exception), Action="http://services.webservices.sfh.osinergmin.com/LabCalidadPortType/registrarInform" +
            "eLabGlpCalidad/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Osinergmin.registrarInformeLabGlpCalidadResponse> registrarInformeLabGlpCalidadAsync(Osinergmin.registrarInformeLabGlpCalidadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarGuiaMuestras", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarGuiaMuestrasRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.cabeceraMuestra cabeceraMuestra;
        
        public registrarGuiaMuestrasRequest()
        {
        }
        
        public registrarGuiaMuestrasRequest(Osinergmin.cabeceraMuestra cabeceraMuestra)
        {
            this.cabeceraMuestra = cabeceraMuestra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarGuiaMuestrasResponse", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarGuiaMuestrasResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarGuiaMuestrasResponse", Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.parametro registrarGuiaMuestrasResponse1;
        
        public registrarGuiaMuestrasResponse()
        {
        }
        
        public registrarGuiaMuestrasResponse(Osinergmin.parametro registrarGuiaMuestrasResponse1)
        {
            this.registrarGuiaMuestrasResponse1 = registrarGuiaMuestrasResponse1;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class detalleMuestra
    {
        
        private float cantidadMuestrasField;
        
        private bool cantidadMuestrasFieldSpecified;
        
        private string claveUsuarioField;
        
        private string codigoEstablecimientoField;
        
        private string codigoProductoField;
        
        private string fechaMuestreoField;
        
        private string fotoMuestraField;
        
        private string loginUsuarioField;
        
        private string nombreFotoField;
        
        private string numeroActaField;
        
        private long numeroGuiaField;
        
        private bool numeroGuiaFieldSpecified;
        
        private int numeroMuestraField;
        
        private bool numeroMuestraFieldSpecified;
        
        private string numeroPrecintoDirimenciaField;
        
        private string numeroPrecintoLaboratorioField;
        
        private string observacionesField;
        
        private string origenProductoField;
        
        private string tipoEnvaseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public float cantidadMuestras
        {
            get
            {
                return this.cantidadMuestrasField;
            }
            set
            {
                this.cantidadMuestrasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cantidadMuestrasSpecified
        {
            get
            {
                return this.cantidadMuestrasFieldSpecified;
            }
            set
            {
                this.cantidadMuestrasFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string claveUsuario
        {
            get
            {
                return this.claveUsuarioField;
            }
            set
            {
                this.claveUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string codigoEstablecimiento
        {
            get
            {
                return this.codigoEstablecimientoField;
            }
            set
            {
                this.codigoEstablecimientoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string codigoProducto
        {
            get
            {
                return this.codigoProductoField;
            }
            set
            {
                this.codigoProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string fechaMuestreo
        {
            get
            {
                return this.fechaMuestreoField;
            }
            set
            {
                this.fechaMuestreoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string fotoMuestra
        {
            get
            {
                return this.fotoMuestraField;
            }
            set
            {
                this.fotoMuestraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string loginUsuario
        {
            get
            {
                return this.loginUsuarioField;
            }
            set
            {
                this.loginUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string nombreFoto
        {
            get
            {
                return this.nombreFotoField;
            }
            set
            {
                this.nombreFotoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string numeroActa
        {
            get
            {
                return this.numeroActaField;
            }
            set
            {
                this.numeroActaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long numeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroGuiaSpecified
        {
            get
            {
                return this.numeroGuiaFieldSpecified;
            }
            set
            {
                this.numeroGuiaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int numeroMuestra
        {
            get
            {
                return this.numeroMuestraField;
            }
            set
            {
                this.numeroMuestraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroMuestraSpecified
        {
            get
            {
                return this.numeroMuestraFieldSpecified;
            }
            set
            {
                this.numeroMuestraFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string numeroPrecintoDirimencia
        {
            get
            {
                return this.numeroPrecintoDirimenciaField;
            }
            set
            {
                this.numeroPrecintoDirimenciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string numeroPrecintoLaboratorio
        {
            get
            {
                return this.numeroPrecintoLaboratorioField;
            }
            set
            {
                this.numeroPrecintoLaboratorioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string origenProducto
        {
            get
            {
                return this.origenProductoField;
            }
            set
            {
                this.origenProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string tipoEnvase
        {
            get
            {
                return this.tipoEnvaseField;
            }
            set
            {
                this.tipoEnvaseField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarGuiaMuestrasDetalle", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarGuiaMuestrasDetalleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.detalleMuestra detalleMuestra;
        
        public registrarGuiaMuestrasDetalleRequest()
        {
        }
        
        public registrarGuiaMuestrasDetalleRequest(Osinergmin.detalleMuestra detalleMuestra)
        {
            this.detalleMuestra = detalleMuestra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarGuiaMuestrasDetalleResponse", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarGuiaMuestrasDetalleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarGuiaMuestrasDetalleResponse", Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.parametro registrarGuiaMuestrasDetalleResponse1;
        
        public registrarGuiaMuestrasDetalleResponse()
        {
        }
        
        public registrarGuiaMuestrasDetalleResponse(Osinergmin.parametro registrarGuiaMuestrasDetalleResponse1)
        {
            this.registrarGuiaMuestrasDetalleResponse1 = registrarGuiaMuestrasDetalleResponse1;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class guiaMuestra
    {
        
        private string claveUsuarioField;
        
        private string loginUsuarioField;
        
        private long numeroGuiaField;
        
        private bool numeroGuiaFieldSpecified;
        
        private string seEstaVersionandoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string claveUsuario
        {
            get
            {
                return this.claveUsuarioField;
            }
            set
            {
                this.claveUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string loginUsuario
        {
            get
            {
                return this.loginUsuarioField;
            }
            set
            {
                this.loginUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long numeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroGuiaSpecified
        {
            get
            {
                return this.numeroGuiaFieldSpecified;
            }
            set
            {
                this.numeroGuiaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string seEstaVersionando
        {
            get
            {
                return this.seEstaVersionandoField;
            }
            set
            {
                this.seEstaVersionandoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="presentarGuiaMuestras", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class presentarGuiaMuestrasRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.guiaMuestra guiaMuestra;
        
        public presentarGuiaMuestrasRequest()
        {
        }
        
        public presentarGuiaMuestrasRequest(Osinergmin.guiaMuestra guiaMuestra)
        {
            this.guiaMuestra = guiaMuestra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="presentarGuiaMuestrasResponse", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class presentarGuiaMuestrasResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="presentarGuiaMuestrasResponse", Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.parametro presentarGuiaMuestrasResponse1;
        
        public presentarGuiaMuestrasResponse()
        {
        }
        
        public presentarGuiaMuestrasResponse(Osinergmin.parametro presentarGuiaMuestrasResponse1)
        {
            this.presentarGuiaMuestrasResponse1 = presentarGuiaMuestrasResponse1;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class getEnsayosPorMuestras
    {
        
        private string claveUsuarioField;
        
        private long codigoVerificacionField;
        
        private bool codigoVerificacionFieldSpecified;
        
        private string loginUsuarioField;
        
        private long numeroGuiaField;
        
        private bool numeroGuiaFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string claveUsuario
        {
            get
            {
                return this.claveUsuarioField;
            }
            set
            {
                this.claveUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long codigoVerificacion
        {
            get
            {
                return this.codigoVerificacionField;
            }
            set
            {
                this.codigoVerificacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoVerificacionSpecified
        {
            get
            {
                return this.codigoVerificacionFieldSpecified;
            }
            set
            {
                this.codigoVerificacionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string loginUsuario
        {
            get
            {
                return this.loginUsuarioField;
            }
            set
            {
                this.loginUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long numeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroGuiaSpecified
        {
            get
            {
                return this.numeroGuiaFieldSpecified;
            }
            set
            {
                this.numeroGuiaFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class ensayosPorMuestras
    {
        
        private long codigoVerificacionField;
        
        private bool codigoVerificacionFieldSpecified;
        
        private string comentarioField;
        
        private string[] ensayosField;
        
        private long numeroGuiaField;
        
        private bool numeroGuiaFieldSpecified;
        
        private int numeroMuestraField;
        
        private bool numeroMuestraFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long codigoVerificacion
        {
            get
            {
                return this.codigoVerificacionField;
            }
            set
            {
                this.codigoVerificacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoVerificacionSpecified
        {
            get
            {
                return this.codigoVerificacionFieldSpecified;
            }
            set
            {
                this.codigoVerificacionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string comentario
        {
            get
            {
                return this.comentarioField;
            }
            set
            {
                this.comentarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ensayos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string[] ensayos
        {
            get
            {
                return this.ensayosField;
            }
            set
            {
                this.ensayosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long numeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroGuiaSpecified
        {
            get
            {
                return this.numeroGuiaFieldSpecified;
            }
            set
            {
                this.numeroGuiaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int numeroMuestra
        {
            get
            {
                return this.numeroMuestraField;
            }
            set
            {
                this.numeroMuestraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroMuestraSpecified
        {
            get
            {
                return this.numeroMuestraFieldSpecified;
            }
            set
            {
                this.numeroMuestraFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerValidacionPorMuestra", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class obtenerValidacionPorMuestraRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.getEnsayosPorMuestras getValidacion;
        
        public obtenerValidacionPorMuestraRequest()
        {
        }
        
        public obtenerValidacionPorMuestraRequest(Osinergmin.getEnsayosPorMuestras getValidacion)
        {
            this.getValidacion = getValidacion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerValidacionPorMuestraResponse", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class obtenerValidacionPorMuestraResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="obtenerValidacionPorMuestraResponse", Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("obtenerValidacionPorMuestraResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Osinergmin.ensayosPorMuestras[] obtenerValidacionPorMuestraResponse1;
        
        public obtenerValidacionPorMuestraResponse()
        {
        }
        
        public obtenerValidacionPorMuestraResponse(Osinergmin.ensayosPorMuestras[] obtenerValidacionPorMuestraResponse1)
        {
            this.obtenerValidacionPorMuestraResponse1 = obtenerValidacionPorMuestraResponse1;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class informeLiquido
    {
        
        private string aguaPorDestilacionField;
        
        private string aguaSedimentosField;
        
        private float astmd86_10pField;
        
        private bool astmd86_10pFieldSpecified;
        
        private float astmd86_20pField;
        
        private bool astmd86_20pFieldSpecified;
        
        private float astmd86_50pField;
        
        private bool astmd86_50pFieldSpecified;
        
        private float astmd86_5pField;
        
        private bool astmd86_5pFieldSpecified;
        
        private float astmd86_90pField;
        
        private bool astmd86_90pFieldSpecified;
        
        private float astmd86_95pField;
        
        private bool astmd86_95pFieldSpecified;
        
        private float astmd86_perdidasField;
        
        private bool astmd86_perdidasFieldSpecified;
        
        private float astmd86_pfeField;
        
        private bool astmd86_pfeFieldSpecified;
        
        private float astmd86_pieField;
        
        private bool astmd86_pieFieldSpecified;
        
        private float astmd86_recupField;
        
        private bool astmd86_recupFieldSpecified;
        
        private float astmd86_residuoField;
        
        private bool astmd86_residuoFieldSpecified;
        
        private string claveUsuarioField;
        
        private string colorField;
        
        private string contaminacionParticulasField;
        
        private string contenidoAzufre4294Field;
        
        private string contenidoAzufre5453Field;
        
        private string contenidoDipeMasaField;
        
        private string contenidoDipeVolumenField;
        
        private string contenidoEtanolMasaField;
        
        private string contenidoEtanolVolumenField;
        
        private string contenidoEtbeMasaField;
        
        private string contenidoEtbeVolumenField;
        
        private float contenidoFameVolumenField;
        
        private bool contenidoFameVolumenFieldSpecified;
        
        private string contenidoGomasField;
        
        private float contenidoManganesoField;
        
        private bool contenidoManganesoFieldSpecified;
        
        private string contenidoMetanolMasaField;
        
        private string contenidoMetanolVolumenField;
        
        private string contenidoMtbeMasaField;
        
        private string contenidoMtbeVolumenField;
        
        private string contenidoPlomoField;
        
        private string contenidoPlomoAstmd3237Field;
        
        private string contenidoPlomoAstmd3341Field;
        
        private string contenidoSolidosField;
        
        private string contenidoTameMasaField;
        
        private string contenidoTameVolumenField;
        
        private string contenidoTertbutanoMasaField;
        
        private string contenidoTertbutanoVolumenField;
        
        private float densidadRelativaField;
        
        private bool densidadRelativaFieldSpecified;
        
        private float determinacionBencenoField;
        
        private bool determinacionBencenoFieldSpecified;
        
        private string fechValidacionField;
        
        private float gravidadApiField;
        
        private bool gravidadApiFieldSpecified;
        
        private float indiceCetanoField;
        
        private bool indiceCetanoFieldSpecified;
        
        private float indiceCetanoBajoAzufreField;
        
        private bool indiceCetanoBajoAzufreFieldSpecified;
        
        private string indiceCetanoFmeField;
        
        private float indiceCetanoProcedenciaAField;
        
        private bool indiceCetanoProcedenciaAFieldSpecified;
        
        private float indiceCetanoProcedenciaBField;
        
        private bool indiceCetanoProcedenciaBFieldSpecified;
        
        private string loginUsuarioField;
        
        private long nroGuiaField;
        
        private bool nroGuiaFieldSpecified;
        
        private int nroMuestraField;
        
        private bool nroMuestraFieldSpecified;
        
        private string numeroInformeLaboratorioField;
        
        private string observacionesField;
        
        private string octanajeField;
        
        private float presionVaporReidField;
        
        private bool presionVaporReidFieldSpecified;
        
        private string puntoCongelamientoField;
        
        private string puntoEscurrimientoField;
        
        private string puntoInflamacionField;
        
        private float reaccionAlAguaField;
        
        private bool reaccionAlAguaFieldSpecified;
        
        private string remanenteRetiradoField;
        
        private string resultadoFinalField;
        
        private string totalOxigenadosMasaField;
        
        private string totalOxigenadosVolumenField;
        
        private string totalOxigenoField;
        
        private float viscosidadCinematicaField;
        
        private bool viscosidadCinematicaFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string aguaPorDestilacion
        {
            get
            {
                return this.aguaPorDestilacionField;
            }
            set
            {
                this.aguaPorDestilacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string aguaSedimentos
        {
            get
            {
                return this.aguaSedimentosField;
            }
            set
            {
                this.aguaSedimentosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public float astmd86_10p
        {
            get
            {
                return this.astmd86_10pField;
            }
            set
            {
                this.astmd86_10pField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_10pSpecified
        {
            get
            {
                return this.astmd86_10pFieldSpecified;
            }
            set
            {
                this.astmd86_10pFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public float astmd86_20p
        {
            get
            {
                return this.astmd86_20pField;
            }
            set
            {
                this.astmd86_20pField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_20pSpecified
        {
            get
            {
                return this.astmd86_20pFieldSpecified;
            }
            set
            {
                this.astmd86_20pFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public float astmd86_50p
        {
            get
            {
                return this.astmd86_50pField;
            }
            set
            {
                this.astmd86_50pField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_50pSpecified
        {
            get
            {
                return this.astmd86_50pFieldSpecified;
            }
            set
            {
                this.astmd86_50pFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public float astmd86_5p
        {
            get
            {
                return this.astmd86_5pField;
            }
            set
            {
                this.astmd86_5pField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_5pSpecified
        {
            get
            {
                return this.astmd86_5pFieldSpecified;
            }
            set
            {
                this.astmd86_5pFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public float astmd86_90p
        {
            get
            {
                return this.astmd86_90pField;
            }
            set
            {
                this.astmd86_90pField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_90pSpecified
        {
            get
            {
                return this.astmd86_90pFieldSpecified;
            }
            set
            {
                this.astmd86_90pFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public float astmd86_95p
        {
            get
            {
                return this.astmd86_95pField;
            }
            set
            {
                this.astmd86_95pField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_95pSpecified
        {
            get
            {
                return this.astmd86_95pFieldSpecified;
            }
            set
            {
                this.astmd86_95pFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public float astmd86_perdidas
        {
            get
            {
                return this.astmd86_perdidasField;
            }
            set
            {
                this.astmd86_perdidasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_perdidasSpecified
        {
            get
            {
                return this.astmd86_perdidasFieldSpecified;
            }
            set
            {
                this.astmd86_perdidasFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public float astmd86_pfe
        {
            get
            {
                return this.astmd86_pfeField;
            }
            set
            {
                this.astmd86_pfeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_pfeSpecified
        {
            get
            {
                return this.astmd86_pfeFieldSpecified;
            }
            set
            {
                this.astmd86_pfeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public float astmd86_pie
        {
            get
            {
                return this.astmd86_pieField;
            }
            set
            {
                this.astmd86_pieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_pieSpecified
        {
            get
            {
                return this.astmd86_pieFieldSpecified;
            }
            set
            {
                this.astmd86_pieFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public float astmd86_recup
        {
            get
            {
                return this.astmd86_recupField;
            }
            set
            {
                this.astmd86_recupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_recupSpecified
        {
            get
            {
                return this.astmd86_recupFieldSpecified;
            }
            set
            {
                this.astmd86_recupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public float astmd86_residuo
        {
            get
            {
                return this.astmd86_residuoField;
            }
            set
            {
                this.astmd86_residuoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool astmd86_residuoSpecified
        {
            get
            {
                return this.astmd86_residuoFieldSpecified;
            }
            set
            {
                this.astmd86_residuoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string claveUsuario
        {
            get
            {
                return this.claveUsuarioField;
            }
            set
            {
                this.claveUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string contaminacionParticulas
        {
            get
            {
                return this.contaminacionParticulasField;
            }
            set
            {
                this.contaminacionParticulasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string contenidoAzufre4294
        {
            get
            {
                return this.contenidoAzufre4294Field;
            }
            set
            {
                this.contenidoAzufre4294Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string contenidoAzufre5453
        {
            get
            {
                return this.contenidoAzufre5453Field;
            }
            set
            {
                this.contenidoAzufre5453Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string contenidoDipeMasa
        {
            get
            {
                return this.contenidoDipeMasaField;
            }
            set
            {
                this.contenidoDipeMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public string contenidoDipeVolumen
        {
            get
            {
                return this.contenidoDipeVolumenField;
            }
            set
            {
                this.contenidoDipeVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string contenidoEtanolMasa
        {
            get
            {
                return this.contenidoEtanolMasaField;
            }
            set
            {
                this.contenidoEtanolMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string contenidoEtanolVolumen
        {
            get
            {
                return this.contenidoEtanolVolumenField;
            }
            set
            {
                this.contenidoEtanolVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string contenidoEtbeMasa
        {
            get
            {
                return this.contenidoEtbeMasaField;
            }
            set
            {
                this.contenidoEtbeMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public string contenidoEtbeVolumen
        {
            get
            {
                return this.contenidoEtbeVolumenField;
            }
            set
            {
                this.contenidoEtbeVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public float contenidoFameVolumen
        {
            get
            {
                return this.contenidoFameVolumenField;
            }
            set
            {
                this.contenidoFameVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contenidoFameVolumenSpecified
        {
            get
            {
                return this.contenidoFameVolumenFieldSpecified;
            }
            set
            {
                this.contenidoFameVolumenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public string contenidoGomas
        {
            get
            {
                return this.contenidoGomasField;
            }
            set
            {
                this.contenidoGomasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public float contenidoManganeso
        {
            get
            {
                return this.contenidoManganesoField;
            }
            set
            {
                this.contenidoManganesoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contenidoManganesoSpecified
        {
            get
            {
                return this.contenidoManganesoFieldSpecified;
            }
            set
            {
                this.contenidoManganesoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public string contenidoMetanolMasa
        {
            get
            {
                return this.contenidoMetanolMasaField;
            }
            set
            {
                this.contenidoMetanolMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public string contenidoMetanolVolumen
        {
            get
            {
                return this.contenidoMetanolVolumenField;
            }
            set
            {
                this.contenidoMetanolVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public string contenidoMtbeMasa
        {
            get
            {
                return this.contenidoMtbeMasaField;
            }
            set
            {
                this.contenidoMtbeMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public string contenidoMtbeVolumen
        {
            get
            {
                return this.contenidoMtbeVolumenField;
            }
            set
            {
                this.contenidoMtbeVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public string contenidoPlomo
        {
            get
            {
                return this.contenidoPlomoField;
            }
            set
            {
                this.contenidoPlomoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public string contenidoPlomoAstmd3237
        {
            get
            {
                return this.contenidoPlomoAstmd3237Field;
            }
            set
            {
                this.contenidoPlomoAstmd3237Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=33)]
        public string contenidoPlomoAstmd3341
        {
            get
            {
                return this.contenidoPlomoAstmd3341Field;
            }
            set
            {
                this.contenidoPlomoAstmd3341Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=34)]
        public string contenidoSolidos
        {
            get
            {
                return this.contenidoSolidosField;
            }
            set
            {
                this.contenidoSolidosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=35)]
        public string contenidoTameMasa
        {
            get
            {
                return this.contenidoTameMasaField;
            }
            set
            {
                this.contenidoTameMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=36)]
        public string contenidoTameVolumen
        {
            get
            {
                return this.contenidoTameVolumenField;
            }
            set
            {
                this.contenidoTameVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=37)]
        public string contenidoTertbutanoMasa
        {
            get
            {
                return this.contenidoTertbutanoMasaField;
            }
            set
            {
                this.contenidoTertbutanoMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=38)]
        public string contenidoTertbutanoVolumen
        {
            get
            {
                return this.contenidoTertbutanoVolumenField;
            }
            set
            {
                this.contenidoTertbutanoVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=39)]
        public float densidadRelativa
        {
            get
            {
                return this.densidadRelativaField;
            }
            set
            {
                this.densidadRelativaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool densidadRelativaSpecified
        {
            get
            {
                return this.densidadRelativaFieldSpecified;
            }
            set
            {
                this.densidadRelativaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=40)]
        public float determinacionBenceno
        {
            get
            {
                return this.determinacionBencenoField;
            }
            set
            {
                this.determinacionBencenoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool determinacionBencenoSpecified
        {
            get
            {
                return this.determinacionBencenoFieldSpecified;
            }
            set
            {
                this.determinacionBencenoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=41)]
        public string fechValidacion
        {
            get
            {
                return this.fechValidacionField;
            }
            set
            {
                this.fechValidacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=42)]
        public float gravidadApi
        {
            get
            {
                return this.gravidadApiField;
            }
            set
            {
                this.gravidadApiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gravidadApiSpecified
        {
            get
            {
                return this.gravidadApiFieldSpecified;
            }
            set
            {
                this.gravidadApiFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=43)]
        public float indiceCetano
        {
            get
            {
                return this.indiceCetanoField;
            }
            set
            {
                this.indiceCetanoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indiceCetanoSpecified
        {
            get
            {
                return this.indiceCetanoFieldSpecified;
            }
            set
            {
                this.indiceCetanoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=44)]
        public float indiceCetanoBajoAzufre
        {
            get
            {
                return this.indiceCetanoBajoAzufreField;
            }
            set
            {
                this.indiceCetanoBajoAzufreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indiceCetanoBajoAzufreSpecified
        {
            get
            {
                return this.indiceCetanoBajoAzufreFieldSpecified;
            }
            set
            {
                this.indiceCetanoBajoAzufreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=45)]
        public string indiceCetanoFme
        {
            get
            {
                return this.indiceCetanoFmeField;
            }
            set
            {
                this.indiceCetanoFmeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=46)]
        public float indiceCetanoProcedenciaA
        {
            get
            {
                return this.indiceCetanoProcedenciaAField;
            }
            set
            {
                this.indiceCetanoProcedenciaAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indiceCetanoProcedenciaASpecified
        {
            get
            {
                return this.indiceCetanoProcedenciaAFieldSpecified;
            }
            set
            {
                this.indiceCetanoProcedenciaAFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=47)]
        public float indiceCetanoProcedenciaB
        {
            get
            {
                return this.indiceCetanoProcedenciaBField;
            }
            set
            {
                this.indiceCetanoProcedenciaBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indiceCetanoProcedenciaBSpecified
        {
            get
            {
                return this.indiceCetanoProcedenciaBFieldSpecified;
            }
            set
            {
                this.indiceCetanoProcedenciaBFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=48)]
        public string loginUsuario
        {
            get
            {
                return this.loginUsuarioField;
            }
            set
            {
                this.loginUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=49)]
        public long nroGuia
        {
            get
            {
                return this.nroGuiaField;
            }
            set
            {
                this.nroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nroGuiaSpecified
        {
            get
            {
                return this.nroGuiaFieldSpecified;
            }
            set
            {
                this.nroGuiaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=50)]
        public int nroMuestra
        {
            get
            {
                return this.nroMuestraField;
            }
            set
            {
                this.nroMuestraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nroMuestraSpecified
        {
            get
            {
                return this.nroMuestraFieldSpecified;
            }
            set
            {
                this.nroMuestraFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=51)]
        public string numeroInformeLaboratorio
        {
            get
            {
                return this.numeroInformeLaboratorioField;
            }
            set
            {
                this.numeroInformeLaboratorioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=52)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=53)]
        public string octanaje
        {
            get
            {
                return this.octanajeField;
            }
            set
            {
                this.octanajeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=54)]
        public float presionVaporReid
        {
            get
            {
                return this.presionVaporReidField;
            }
            set
            {
                this.presionVaporReidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presionVaporReidSpecified
        {
            get
            {
                return this.presionVaporReidFieldSpecified;
            }
            set
            {
                this.presionVaporReidFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=55)]
        public string puntoCongelamiento
        {
            get
            {
                return this.puntoCongelamientoField;
            }
            set
            {
                this.puntoCongelamientoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=56)]
        public string puntoEscurrimiento
        {
            get
            {
                return this.puntoEscurrimientoField;
            }
            set
            {
                this.puntoEscurrimientoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=57)]
        public string puntoInflamacion
        {
            get
            {
                return this.puntoInflamacionField;
            }
            set
            {
                this.puntoInflamacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=58)]
        public float reaccionAlAgua
        {
            get
            {
                return this.reaccionAlAguaField;
            }
            set
            {
                this.reaccionAlAguaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reaccionAlAguaSpecified
        {
            get
            {
                return this.reaccionAlAguaFieldSpecified;
            }
            set
            {
                this.reaccionAlAguaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=59)]
        public string remanenteRetirado
        {
            get
            {
                return this.remanenteRetiradoField;
            }
            set
            {
                this.remanenteRetiradoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=60)]
        public string resultadoFinal
        {
            get
            {
                return this.resultadoFinalField;
            }
            set
            {
                this.resultadoFinalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=61)]
        public string totalOxigenadosMasa
        {
            get
            {
                return this.totalOxigenadosMasaField;
            }
            set
            {
                this.totalOxigenadosMasaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=62)]
        public string totalOxigenadosVolumen
        {
            get
            {
                return this.totalOxigenadosVolumenField;
            }
            set
            {
                this.totalOxigenadosVolumenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=63)]
        public string totalOxigeno
        {
            get
            {
                return this.totalOxigenoField;
            }
            set
            {
                this.totalOxigenoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=64)]
        public float viscosidadCinematica
        {
            get
            {
                return this.viscosidadCinematicaField;
            }
            set
            {
                this.viscosidadCinematicaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool viscosidadCinematicaSpecified
        {
            get
            {
                return this.viscosidadCinematicaFieldSpecified;
            }
            set
            {
                this.viscosidadCinematicaFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarInformeLabLiquidoCalidad", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarInformeLabLiquidoCalidadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.informeLiquido informeLiquido;
        
        public registrarInformeLabLiquidoCalidadRequest()
        {
        }
        
        public registrarInformeLabLiquidoCalidadRequest(Osinergmin.informeLiquido informeLiquido)
        {
            this.informeLiquido = informeLiquido;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarInformeLabLiquidoCalidadResponse", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarInformeLabLiquidoCalidadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarInformeLabLiquidoCalidadResponse", Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.parametro registrarInformeLabLiquidoCalidadResponse1;
        
        public registrarInformeLabLiquidoCalidadResponse()
        {
        }
        
        public registrarInformeLabLiquidoCalidadResponse(Osinergmin.parametro registrarInformeLabLiquidoCalidadResponse1)
        {
            this.registrarInformeLabLiquidoCalidadResponse1 = registrarInformeLabLiquidoCalidadResponse1;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.webservices.sfh.osinergmin.com")]
    public partial class informeGlp
    {
        
        private string butadienoMolField;
        
        private string butenoMolField;
        
        private float cis2butenoMolField;
        
        private bool cis2butenoMolFieldSpecified;
        
        private string claveUsuarioField;
        
        private string corrosionLaminaCobreField;
        
        private float densidadRelativaField;
        
        private bool densidadRelativaFieldSpecified;
        
        private float determinacionEtilMercaptanoField;
        
        private bool determinacionEtilMercaptanoFieldSpecified;
        
        private string etanoMolField;
        
        private string etilenoMolField;
        
        private string hexanoField;
        
        private float isobutanoMolField;
        
        private bool isobutanoMolFieldSpecified;
        
        private string isobutilenoMolField;
        
        private float isopentanoMolField;
        
        private bool isopentanoMolFieldSpecified;
        
        private string loginUsuarioField;
        
        private string metanoMolField;
        
        private float nbutanoMolField;
        
        private bool nbutanoMolFieldSpecified;
        
        private string npentanoMolField;
        
        private long nroGuiaField;
        
        private bool nroGuiaFieldSpecified;
        
        private int nroMuestraField;
        
        private bool nroMuestraFieldSpecified;
        
        private string numeroInformeLaboratorioField;
        
        private string numeroOctanoMotorField;
        
        private string observacionesField;
        
        private float presionVaporField;
        
        private bool presionVaporFieldSpecified;
        
        private float propanoMolField;
        
        private bool propanoMolFieldSpecified;
        
        private string propilenoMolField;
        
        private string trans2butenoMolField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string butadienoMol
        {
            get
            {
                return this.butadienoMolField;
            }
            set
            {
                this.butadienoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string butenoMol
        {
            get
            {
                return this.butenoMolField;
            }
            set
            {
                this.butenoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public float cis2butenoMol
        {
            get
            {
                return this.cis2butenoMolField;
            }
            set
            {
                this.cis2butenoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cis2butenoMolSpecified
        {
            get
            {
                return this.cis2butenoMolFieldSpecified;
            }
            set
            {
                this.cis2butenoMolFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string claveUsuario
        {
            get
            {
                return this.claveUsuarioField;
            }
            set
            {
                this.claveUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string corrosionLaminaCobre
        {
            get
            {
                return this.corrosionLaminaCobreField;
            }
            set
            {
                this.corrosionLaminaCobreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public float densidadRelativa
        {
            get
            {
                return this.densidadRelativaField;
            }
            set
            {
                this.densidadRelativaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool densidadRelativaSpecified
        {
            get
            {
                return this.densidadRelativaFieldSpecified;
            }
            set
            {
                this.densidadRelativaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public float determinacionEtilMercaptano
        {
            get
            {
                return this.determinacionEtilMercaptanoField;
            }
            set
            {
                this.determinacionEtilMercaptanoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool determinacionEtilMercaptanoSpecified
        {
            get
            {
                return this.determinacionEtilMercaptanoFieldSpecified;
            }
            set
            {
                this.determinacionEtilMercaptanoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string etanoMol
        {
            get
            {
                return this.etanoMolField;
            }
            set
            {
                this.etanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string etilenoMol
        {
            get
            {
                return this.etilenoMolField;
            }
            set
            {
                this.etilenoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string hexano
        {
            get
            {
                return this.hexanoField;
            }
            set
            {
                this.hexanoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public float isobutanoMol
        {
            get
            {
                return this.isobutanoMolField;
            }
            set
            {
                this.isobutanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isobutanoMolSpecified
        {
            get
            {
                return this.isobutanoMolFieldSpecified;
            }
            set
            {
                this.isobutanoMolFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string isobutilenoMol
        {
            get
            {
                return this.isobutilenoMolField;
            }
            set
            {
                this.isobutilenoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public float isopentanoMol
        {
            get
            {
                return this.isopentanoMolField;
            }
            set
            {
                this.isopentanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isopentanoMolSpecified
        {
            get
            {
                return this.isopentanoMolFieldSpecified;
            }
            set
            {
                this.isopentanoMolFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string loginUsuario
        {
            get
            {
                return this.loginUsuarioField;
            }
            set
            {
                this.loginUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string metanoMol
        {
            get
            {
                return this.metanoMolField;
            }
            set
            {
                this.metanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public float nbutanoMol
        {
            get
            {
                return this.nbutanoMolField;
            }
            set
            {
                this.nbutanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nbutanoMolSpecified
        {
            get
            {
                return this.nbutanoMolFieldSpecified;
            }
            set
            {
                this.nbutanoMolFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string npentanoMol
        {
            get
            {
                return this.npentanoMolField;
            }
            set
            {
                this.npentanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public long nroGuia
        {
            get
            {
                return this.nroGuiaField;
            }
            set
            {
                this.nroGuiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nroGuiaSpecified
        {
            get
            {
                return this.nroGuiaFieldSpecified;
            }
            set
            {
                this.nroGuiaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public int nroMuestra
        {
            get
            {
                return this.nroMuestraField;
            }
            set
            {
                this.nroMuestraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nroMuestraSpecified
        {
            get
            {
                return this.nroMuestraFieldSpecified;
            }
            set
            {
                this.nroMuestraFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public string numeroInformeLaboratorio
        {
            get
            {
                return this.numeroInformeLaboratorioField;
            }
            set
            {
                this.numeroInformeLaboratorioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string numeroOctanoMotor
        {
            get
            {
                return this.numeroOctanoMotorField;
            }
            set
            {
                this.numeroOctanoMotorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public float presionVapor
        {
            get
            {
                return this.presionVaporField;
            }
            set
            {
                this.presionVaporField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presionVaporSpecified
        {
            get
            {
                return this.presionVaporFieldSpecified;
            }
            set
            {
                this.presionVaporFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public float propanoMol
        {
            get
            {
                return this.propanoMolField;
            }
            set
            {
                this.propanoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool propanoMolSpecified
        {
            get
            {
                return this.propanoMolFieldSpecified;
            }
            set
            {
                this.propanoMolFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public string propilenoMol
        {
            get
            {
                return this.propilenoMolField;
            }
            set
            {
                this.propilenoMolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public string trans2butenoMol
        {
            get
            {
                return this.trans2butenoMolField;
            }
            set
            {
                this.trans2butenoMolField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarInformeLabGlpCalidad", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarInformeLabGlpCalidadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.informeGlp informeGlp;
        
        public registrarInformeLabGlpCalidadRequest()
        {
        }
        
        public registrarInformeLabGlpCalidadRequest(Osinergmin.informeGlp informeGlp)
        {
            this.informeGlp = informeGlp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarInformeLabGlpCalidadResponse", WrapperNamespace="http://services.webservices.sfh.osinergmin.com", IsWrapped=true)]
    public partial class registrarInformeLabGlpCalidadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarInformeLabGlpCalidadResponse", Namespace="http://services.webservices.sfh.osinergmin.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Osinergmin.parametro registrarInformeLabGlpCalidadResponse1;
        
        public registrarInformeLabGlpCalidadResponse()
        {
        }
        
        public registrarInformeLabGlpCalidadResponse(Osinergmin.parametro registrarInformeLabGlpCalidadResponse1)
        {
            this.registrarInformeLabGlpCalidadResponse1 = registrarInformeLabGlpCalidadResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface LabCalidadPortTypeChannel : Osinergmin.LabCalidadPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class LabCalidadPortTypeClient : System.ServiceModel.ClientBase<Osinergmin.LabCalidadPortType>, Osinergmin.LabCalidadPortType
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LabCalidadPortTypeClient() : 
                base(LabCalidadPortTypeClient.GetDefaultBinding(), LabCalidadPortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.LabCalidadPortTypePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LabCalidadPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(LabCalidadPortTypeClient.GetBindingForEndpoint(endpointConfiguration), LabCalidadPortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LabCalidadPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LabCalidadPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LabCalidadPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LabCalidadPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LabCalidadPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Osinergmin.registrarGuiaMuestrasResponse> Osinergmin.LabCalidadPortType.registrarGuiaMuestrasAsync(Osinergmin.registrarGuiaMuestrasRequest request)
        {
            return base.Channel.registrarGuiaMuestrasAsync(request);
        }
        
        public System.Threading.Tasks.Task<Osinergmin.registrarGuiaMuestrasResponse> registrarGuiaMuestrasAsync(Osinergmin.cabeceraMuestra cabeceraMuestra)
        {
            Osinergmin.registrarGuiaMuestrasRequest inValue = new Osinergmin.registrarGuiaMuestrasRequest();
            inValue.cabeceraMuestra = cabeceraMuestra;
            return ((Osinergmin.LabCalidadPortType)(this)).registrarGuiaMuestrasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Osinergmin.registrarGuiaMuestrasDetalleResponse> Osinergmin.LabCalidadPortType.registrarGuiaMuestrasDetalleAsync(Osinergmin.registrarGuiaMuestrasDetalleRequest request)
        {
            return base.Channel.registrarGuiaMuestrasDetalleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Osinergmin.registrarGuiaMuestrasDetalleResponse> registrarGuiaMuestrasDetalleAsync(Osinergmin.detalleMuestra detalleMuestra)
        {
            Osinergmin.registrarGuiaMuestrasDetalleRequest inValue = new Osinergmin.registrarGuiaMuestrasDetalleRequest();
            inValue.detalleMuestra = detalleMuestra;
            return ((Osinergmin.LabCalidadPortType)(this)).registrarGuiaMuestrasDetalleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Osinergmin.presentarGuiaMuestrasResponse> Osinergmin.LabCalidadPortType.presentarGuiaMuestrasAsync(Osinergmin.presentarGuiaMuestrasRequest request)
        {
            return base.Channel.presentarGuiaMuestrasAsync(request);
        }
        
        public System.Threading.Tasks.Task<Osinergmin.presentarGuiaMuestrasResponse> presentarGuiaMuestrasAsync(Osinergmin.guiaMuestra guiaMuestra)
        {
            Osinergmin.presentarGuiaMuestrasRequest inValue = new Osinergmin.presentarGuiaMuestrasRequest();
            inValue.guiaMuestra = guiaMuestra;
            return ((Osinergmin.LabCalidadPortType)(this)).presentarGuiaMuestrasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Osinergmin.obtenerValidacionPorMuestraResponse> Osinergmin.LabCalidadPortType.obtenerValidacionPorMuestraAsync(Osinergmin.obtenerValidacionPorMuestraRequest request)
        {
            return base.Channel.obtenerValidacionPorMuestraAsync(request);
        }
        
        public System.Threading.Tasks.Task<Osinergmin.obtenerValidacionPorMuestraResponse> obtenerValidacionPorMuestraAsync(Osinergmin.getEnsayosPorMuestras getValidacion)
        {
            Osinergmin.obtenerValidacionPorMuestraRequest inValue = new Osinergmin.obtenerValidacionPorMuestraRequest();
            inValue.getValidacion = getValidacion;
            return ((Osinergmin.LabCalidadPortType)(this)).obtenerValidacionPorMuestraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Osinergmin.registrarInformeLabLiquidoCalidadResponse> Osinergmin.LabCalidadPortType.registrarInformeLabLiquidoCalidadAsync(Osinergmin.registrarInformeLabLiquidoCalidadRequest request)
        {
            return base.Channel.registrarInformeLabLiquidoCalidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Osinergmin.registrarInformeLabLiquidoCalidadResponse> registrarInformeLabLiquidoCalidadAsync(Osinergmin.informeLiquido informeLiquido)
        {
            Osinergmin.registrarInformeLabLiquidoCalidadRequest inValue = new Osinergmin.registrarInformeLabLiquidoCalidadRequest();
            inValue.informeLiquido = informeLiquido;
            return ((Osinergmin.LabCalidadPortType)(this)).registrarInformeLabLiquidoCalidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Osinergmin.registrarInformeLabGlpCalidadResponse> Osinergmin.LabCalidadPortType.registrarInformeLabGlpCalidadAsync(Osinergmin.registrarInformeLabGlpCalidadRequest request)
        {
            return base.Channel.registrarInformeLabGlpCalidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Osinergmin.registrarInformeLabGlpCalidadResponse> registrarInformeLabGlpCalidadAsync(Osinergmin.informeGlp informeGlp)
        {
            Osinergmin.registrarInformeLabGlpCalidadRequest inValue = new Osinergmin.registrarInformeLabGlpCalidadRequest();
            inValue.informeGlp = informeGlp;
            return ((Osinergmin.LabCalidadPortType)(this)).registrarInformeLabGlpCalidadAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.LabCalidadPortTypePort))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.LabCalidadPortTypePort))
            {
                return new System.ServiceModel.EndpointAddress("https://scopwsdesa.osinergmin.gob.pe/scopws/tjenester/LabCalidadService");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return LabCalidadPortTypeClient.GetBindingForEndpoint(EndpointConfiguration.LabCalidadPortTypePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return LabCalidadPortTypeClient.GetEndpointAddress(EndpointConfiguration.LabCalidadPortTypePort);
        }
        
        public enum EndpointConfiguration
        {
            
            LabCalidadPortTypePort,
        }
    }
}
