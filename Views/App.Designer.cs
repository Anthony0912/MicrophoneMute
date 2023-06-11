
using Entities;
using Features;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Views
{
    public partial class App
    {
        private MicrophoneFeature microphoneFeature;

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void ShowListSoundDevice()
        {
            microphoneFeature = new MicrophoneFeature();
            //microphoneFeature.UnmuteMicrophone();
            microphoneFeature.MuteMicrophone();

            List<DeviceCollection> deviceCollection = microphoneFeature.GetListOfMicrophones();
            foreach (var device in deviceCollection)
            {
                Debug.WriteLine(device.Id);
                Debug.WriteLine(device.Name);
                Debug.WriteLine("========================\n");
            }
            Console.WriteLine("\n\n");
            DeviceCollection d = microphoneFeature.GetDefaultMicrophone();
            Debug.WriteLine(d.Id);
            Debug.WriteLine(d.Name);
        } 

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Inicio";
            this.ShowListSoundDevice();
        }

        #endregion
    }
}

