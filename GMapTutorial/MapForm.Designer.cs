namespace GMapTutorial
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.CBofIds = new System.Windows.Forms.ComboBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnDisplayAllMarkers = new System.Windows.Forms.Button();
            this.lblCB = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConvex = new System.Windows.Forms.Button();
            this.btnMEC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(816, 426);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 13D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            this.gmap.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.gmap_OnPolygonClick);
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(883, 376);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(121, 23);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // CBofIds
            // 
            this.CBofIds.FormattingEnabled = true;
            this.CBofIds.Location = new System.Drawing.Point(883, 70);
            this.CBofIds.Name = "CBofIds";
            this.CBofIds.Size = new System.Drawing.Size(121, 21);
            this.CBofIds.TabIndex = 2;
            this.CBofIds.SelectedIndexChanged += new System.EventHandler(this.CBofIds_SelectedIndexChanged);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(883, 41);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnDisplayAllMarkers
            // 
            this.btnDisplayAllMarkers.Location = new System.Drawing.Point(883, 12);
            this.btnDisplayAllMarkers.Name = "btnDisplayAllMarkers";
            this.btnDisplayAllMarkers.Size = new System.Drawing.Size(121, 23);
            this.btnDisplayAllMarkers.TabIndex = 4;
            this.btnDisplayAllMarkers.Text = "All Markers";
            this.btnDisplayAllMarkers.UseVisualStyleBackColor = true;
            this.btnDisplayAllMarkers.Click += new System.EventHandler(this.btnDisplayAllMarkers_Click);
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Location = new System.Drawing.Point(834, 73);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(43, 13);
            this.lblCB.TabIndex = 5;
            this.lblCB.Text = "User ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(883, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConvex
            // 
            this.btnConvex.Location = new System.Drawing.Point(883, 110);
            this.btnConvex.Name = "btnConvex";
            this.btnConvex.Size = new System.Drawing.Size(121, 23);
            this.btnConvex.TabIndex = 7;
            this.btnConvex.Text = "Convex Hull";
            this.btnConvex.UseVisualStyleBackColor = true;
            this.btnConvex.Click += new System.EventHandler(this.btnConvex_Click);
            // 
            // btnMEC
            // 
            this.btnMEC.Location = new System.Drawing.Point(883, 179);
            this.btnMEC.Name = "btnMEC";
            this.btnMEC.Size = new System.Drawing.Size(121, 23);
            this.btnMEC.TabIndex = 8;
            this.btnMEC.Text = "MEC";
            this.btnMEC.UseVisualStyleBackColor = true;
            this.btnMEC.Click += new System.EventHandler(this.btnMEC_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.btnMEC);
            this.Controls.Add(this.btnConvex);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCB);
            this.Controls.Add(this.btnDisplayAllMarkers);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.CBofIds);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.gmap);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox CBofIds;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnDisplayAllMarkers;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConvex;
        private System.Windows.Forms.Button btnMEC;
    }
}

