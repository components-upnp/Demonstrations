/*
 * Crée par SharpDevelop.
 * Utilisateur: comkostiuk
 * Date: 10/04/2017
 * Heure: 10:44
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using WComp.Beans;

namespace DefaultNamespace
{
	/// <summary>
	/// Description of Container1.
	/// </summary>
	public class Container1 : System.Windows.Forms.Form
	{
        [BeanDesignLocation(552,224)]
        private ONVIF_WS_proxies.ONVIF_ptz.PTZClientProxy pTZClientProxy1;
        [BeanDesignLocation(552,344)]
        private ONVIF_WS_proxies_mux.PTZ_RelativeMove_CallProxy pTZ_RelativeMove_CallProxy1;
        [BeanDesignLocation(360,288)]
        private ONVIF_WS_proxies_factories.ONVIF_ptz_PTZVectorFactoryProxy oNVIF_ptz_PTZVectorFactoryProxy1;
        [BeanDesignLocation(248,480)]
        private ONVIF_WS_proxies_factories.ONVIF_ptz_Vector2DFactoryProxy oNVIF_ptz_Vector2DFactoryProxy1;
        [BeanDesignLocation(56,480)]
        private System.Windows.Forms.Button button1;
        [BeanDesignLocation(240,392)]
        private System.Windows.Forms.Button button2;
        [BeanDesignLocation(496,504)]
        private System.Windows.Forms.Button button3;
        [BeanDesignLocation(584,64)]
        private System.Windows.Forms.Button button4;
        [BeanDesignLocation(208,224)]
        private ONVIF_WS_proxies_factories.ONVIF_ptz_Vector2DFactoryProxy oNVIF_ptz_Vector2DFactoryProxy2;
        [BeanDesignLocation(56,56)]
        private WComp.InterfaceTranslator.StringToFloat stringToFloat1;
        [BeanDesignLocation(168,216)]
        private WComp.InterfaceTranslator.StringToFloat stringToFloat2;
		public Container1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// The InitializeBeans() call is required for WComp.NET designer support.
			//
			InitializeBeans();
			
			//
			// TODO: Add constructor code after the InitializeBeans() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new Container1());
		}
		
		#region WComp.NET designer generated code
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            // 
            // button1
            // 
            this.button1.Text = "Gen Vector2D Right";
            this.button1.Controls = null;
            this.button1.DataBindings = null;
            this.button1.Location = new System.Drawing.Point(56, 480);
            this.button1.Size = new System.Drawing.Size(88, 40);
            // 
            // button2
            // 
            this.button2.Text = "Gen PTZVector";
            this.button2.Controls = null;
            this.button2.DataBindings = null;
            this.button2.Location = new System.Drawing.Point(240, 392);
            this.button2.Size = new System.Drawing.Size(96, 23);
            // 
            // button3
            // 
            this.button3.Text = "Call move";
            this.button3.Controls = null;
            this.button3.DataBindings = null;
            this.button3.Location = new System.Drawing.Point(496, 504);
            this.button3.Size = new System.Drawing.Size(73, 23);
            // 
            // button4
            // 
            this.button4.Text = "Gen Vector2D Left";
            this.button4.Controls = null;
            this.button4.DataBindings = null;
            this.button4.Location = new System.Drawing.Point(640, 64);
            this.button4.Size = new System.Drawing.Size(88, 40);
            // 
            // container
            // 
            this.Text = "SharpWComp static application";
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
        }
		
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeBeans() {
            this.pTZClientProxy1 = new ONVIF_WS_proxies.ONVIF_ptz.PTZClientProxy();
            this.pTZ_RelativeMove_CallProxy1 = new ONVIF_WS_proxies_mux.PTZ_RelativeMove_CallProxy();
            this.oNVIF_ptz_PTZVectorFactoryProxy1 = new ONVIF_WS_proxies_factories.ONVIF_ptz_PTZVectorFactoryProxy();
            this.oNVIF_ptz_Vector2DFactoryProxy1 = new ONVIF_WS_proxies_factories.ONVIF_ptz_Vector2DFactoryProxy();
            this.oNVIF_ptz_Vector2DFactoryProxy2 = new ONVIF_WS_proxies_factories.ONVIF_ptz_Vector2DFactoryProxy();
            this.stringToFloat1 = new WComp.InterfaceTranslator.StringToFloat();
            this.stringToFloat2 = new WComp.InterfaceTranslator.StringToFloat();
            // 
            // pTZClientProxy1
            // 
            this.pTZClientProxy1.XAddr = "http://192.168.0.101:5000/onvif/device_service";
            this.pTZClientProxy1.GetServiceCapabilitiesReturn = null;
            this.pTZClientProxy1.GetNodesReturn = null;
            this.pTZClientProxy1.GetNodeReturn = null;
            this.pTZClientProxy1.GetConfigurationReturn = null;
            this.pTZClientProxy1.GetConfigurationsReturn = null;
            this.pTZClientProxy1.GetConfigurationOptionsReturn = null;
            this.pTZClientProxy1.SendAuxiliaryCommandReturn = null;
            this.pTZClientProxy1.GetPresetsReturn = null;
            this.pTZClientProxy1.SetPresetPresetTokenReturn = null;
            this.pTZClientProxy1.ContinuousMoveReturn = null;
            this.pTZClientProxy1.GetStatusReturn = null;
            this.pTZClientProxy1.GetPresetToursReturn = null;
            this.pTZClientProxy1.GetPresetTourReturn = null;
            this.pTZClientProxy1.GetPresetTourOptionsReturn = null;
            this.pTZClientProxy1.CreatePresetTourReturn = null;
            this.pTZClientProxy1.GetCompatibleConfigurationsReturn = null;
            // 
            // pTZ_RelativeMove_CallProxy1
            // 
            this.pTZ_RelativeMove_CallProxy1.RelativeMove_ProfileToken_CallProxy = null;
            this.pTZ_RelativeMove_CallProxy1.RelativeMove_Translation_CallProxy = null;
            this.pTZ_RelativeMove_CallProxy1.RelativeMove_Speed_CallProxy = null;
            // 
            // oNVIF_ptz_PTZVectorFactoryProxy1
            // 
            this.oNVIF_ptz_PTZVectorFactoryProxy1.PTZVectorOutput = null;
            this.oNVIF_ptz_PTZVectorFactoryProxy1.PanTilt = null;
            this.oNVIF_ptz_PTZVectorFactoryProxy1.Zoom = null;
            // 
            // oNVIF_ptz_Vector2DFactoryProxy1
            // 
            this.oNVIF_ptz_Vector2DFactoryProxy1.Vector2DOutput = null;
            this.oNVIF_ptz_Vector2DFactoryProxy1.x = -12F;
            this.oNVIF_ptz_Vector2DFactoryProxy1.y = 0F;
            this.oNVIF_ptz_Vector2DFactoryProxy1.space = null;
            // 
            // oNVIF_ptz_Vector2DFactoryProxy2
            // 
            this.oNVIF_ptz_Vector2DFactoryProxy2.Vector2DOutput = null;
            this.oNVIF_ptz_Vector2DFactoryProxy2.x = 1F;
            this.oNVIF_ptz_Vector2DFactoryProxy2.y = -1F;
            this.oNVIF_ptz_Vector2DFactoryProxy2.space = null;
            // 
            Control.CheckForIllegalCrossThreadCalls = false;
            // 
            // Event dispatching
            // 
            this.pTZ_RelativeMove_CallProxy1.PTZ_RelativeMove_CallEvent += new ONVIF_WS_proxies_mux.PTZ_RelativeMove_CallProxy.PTZ_RelativeMove_CallDelegate(this.pTZClientProxy1.RelativeMove);
            this.oNVIF_ptz_PTZVectorFactoryProxy1.PTZVectorOutputEvent += new ONVIF_WS_proxies_factories.ONVIF_ptz_PTZVectorFactoryProxy.PTZVectorOutputDelegate(this.@__oNVIF_ptz_PTZVectorFactoryProxy1_to_pTZ_RelativeMove_CallProxy1_0);
            this.oNVIF_ptz_Vector2DFactoryProxy1.Vector2DOutputEvent += new ONVIF_WS_proxies_factories.ONVIF_ptz_Vector2DFactoryProxy.Vector2DOutputDelegate(this.@__oNVIF_ptz_Vector2DFactoryProxy1_to_oNVIF_ptz_PTZVectorFactoryProxy1_1);
            this.button1.Click += new System.EventHandler(this.@__button1_to_oNVIF_ptz_Vector2DFactoryProxy1_2);
            this.button2.Click += new System.EventHandler(this.@__button2_to_oNVIF_ptz_PTZVectorFactoryProxy1_3);
            this.button3.Click += new System.EventHandler(this.@__button3_to_pTZ_RelativeMove_CallProxy1_4);
            this.button4.Click += new System.EventHandler(this.@__button4_to_oNVIF_ptz_Vector2DFactoryProxy2_5);
            this.oNVIF_ptz_Vector2DFactoryProxy2.Vector2DOutputEvent += new ONVIF_WS_proxies_factories.ONVIF_ptz_Vector2DFactoryProxy.Vector2DOutputDelegate(this.@__oNVIF_ptz_Vector2DFactoryProxy2_to_oNVIF_ptz_PTZVectorFactoryProxy1_6);
            this.stringToFloat1.FloatEvent += new WComp.Beans.FloatEventHandler(this.@__stringToFloat1_to_oNVIF_ptz_Vector2DFactoryProxy2_7);
            this.stringToFloat2.FloatEvent += new WComp.Beans.FloatEventHandler(this.@__stringToFloat2_to_oNVIF_ptz_Vector2DFactoryProxy2_8);
        }

		private void @__oNVIF_ptz_PTZVectorFactoryProxy1_to_pTZ_RelativeMove_CallProxy1_0(ONVIF_WS_proxies.ONVIF_ptz.PTZVector PTZVectorOutputValue) {
            this.pTZ_RelativeMove_CallProxy1.RelativeMove_Translation_CallProxy = PTZVectorOutputValue;
        }

		private void @__oNVIF_ptz_Vector2DFactoryProxy1_to_oNVIF_ptz_PTZVectorFactoryProxy1_1(ONVIF_WS_proxies.ONVIF_ptz.Vector2D Vector2DOutputValue) {
            this.oNVIF_ptz_PTZVectorFactoryProxy1.PanTilt = Vector2DOutputValue;
        }

		private void @__button1_to_oNVIF_ptz_Vector2DFactoryProxy1_2(object sender, System.EventArgs e) {
            this.oNVIF_ptz_Vector2DFactoryProxy1.Create_Vector2D_0();
        }

		private void @__button2_to_oNVIF_ptz_PTZVectorFactoryProxy1_3(object sender, System.EventArgs e) {
            this.oNVIF_ptz_PTZVectorFactoryProxy1.Create_PTZVector_0();
        }

		private void @__button3_to_pTZ_RelativeMove_CallProxy1_4(object sender, System.EventArgs e) {
            this.pTZ_RelativeMove_CallProxy1.PTZ_RelativeMove_Trigger();
        }

		private void @__button4_to_oNVIF_ptz_Vector2DFactoryProxy2_5(object sender, System.EventArgs e) {
            this.oNVIF_ptz_Vector2DFactoryProxy2.Create_Vector2D_0();
        }

		private void @__oNVIF_ptz_Vector2DFactoryProxy2_to_oNVIF_ptz_PTZVectorFactoryProxy1_6(ONVIF_WS_proxies.ONVIF_ptz.Vector2D Vector2DOutputValue) {
            this.oNVIF_ptz_PTZVectorFactoryProxy1.PanTilt = Vector2DOutputValue;
        }

		private void @__stringToFloat1_to_oNVIF_ptz_Vector2DFactoryProxy2_7(float f) {
            this.oNVIF_ptz_Vector2DFactoryProxy2.x = f;
        }

		private void @__stringToFloat2_to_oNVIF_ptz_Vector2DFactoryProxy2_8(float f) {
            this.oNVIF_ptz_Vector2DFactoryProxy2.y = f;
        }

		private void @__stringToFloat1_to_oNVIF_ptz_Vector2DFactoryProxy2_7(float f) {
            this.oNVIF_ptz_Vector2DFactoryProxy2.x = f;
        }

		private void @__stringToFloat2_to_oNVIF_ptz_Vector2DFactoryProxy2_8(float f) {
            this.oNVIF_ptz_Vector2DFactoryProxy2.y = f;
        }
		#endregion
	}
}
