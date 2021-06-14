
namespace SmoothArc.forms
{
    partial class form_calendar
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.activeViewBar2 = new DevExpress.XtraScheduler.UI.ActiveViewBar();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
            this.switchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
            this.switchToAgendaViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem();
            this.switchToYearViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToYearViewItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
            this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
            this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.activeViewBar1 = new DevExpress.XtraScheduler.UI.ActiveViewBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutBar1 = new DevExpress.XtraScheduler.UI.LayoutBar();
            this.timeScaleBar1 = new DevExpress.XtraScheduler.UI.TimeScaleBar();
            this.layoutBar2 = new DevExpress.XtraScheduler.UI.LayoutBar();
            this.timeScaleBar2 = new DevExpress.XtraScheduler.UI.TimeScaleBar();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
#pragma warning disable CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
#pragma warning restore CS0618 // 'AppointmentLabel.AppointmentLabel(Color, string, string)' is obsolete: 'Use AppointmentLabelCollection.CreateNewLabel instead.'
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.activeViewBar2});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchToGanttViewItem1,
            this.switchToAgendaViewItem1,
            this.switchToYearViewItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1});
            this.barManager1.MaxItemId = 16;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            // 
            // activeViewBar2
            // 
            this.activeViewBar2.BarAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.activeViewBar2.BarAppearance.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.activeViewBar2.BarAppearance.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.activeViewBar2.BarAppearance.Normal.Options.UseBackColor = true;
            this.activeViewBar2.BarAppearance.Normal.Options.UseBorderColor = true;
            this.activeViewBar2.Control = this.schedulerControl1;
            this.activeViewBar2.DockCol = 0;
            this.activeViewBar2.DockRow = 0;
            this.activeViewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.activeViewBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToDayViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToFullWeekViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToMonthViewItem1)});
            this.activeViewBar2.Offset = 545;
            this.activeViewBar2.OptionsBar.AllowQuickCustomization = false;
            this.activeViewBar2.OptionsBar.DrawDragBorder = false;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Appearance.Appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.schedulerControl1.Appearance.Appointment.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.schedulerControl1.Appearance.Appointment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.schedulerControl1.Appearance.Appointment.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.schedulerControl1.Appearance.Appointment.ForeColor = System.Drawing.Color.White;
            this.schedulerControl1.Appearance.Appointment.Options.UseBackColor = true;
            this.schedulerControl1.Appearance.Appointment.Options.UseBorderColor = true;
            this.schedulerControl1.Appearance.Appointment.Options.UseFont = true;
            this.schedulerControl1.Appearance.Appointment.Options.UseForeColor = true;
            this.schedulerControl1.Appearance.Selection.BackColor = System.Drawing.Color.Silver;
            this.schedulerControl1.Appearance.Selection.BackColor2 = System.Drawing.Color.Silver;
            this.schedulerControl1.Appearance.Selection.BorderColor = System.Drawing.Color.Silver;
            this.schedulerControl1.Appearance.Selection.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.schedulerControl1.Appearance.Selection.Options.UseBackColor = true;
            this.schedulerControl1.Appearance.Selection.Options.UseBorderColor = true;
            this.schedulerControl1.Appearance.Selection.Options.UseFont = true;
            this.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Location = new System.Drawing.Point(27, 30);
            this.schedulerControl1.MenuManager = this.barManager1;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentMultiSelect = false;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentDependencyForm = DevExpress.XtraScheduler.AllowDisplayAppointmentDependencyForm.Never;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = false;
            this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.Never;
            this.schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday;
            this.schedulerControl1.PaintStyleName = "Skin";
            this.schedulerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.schedulerControl1.Size = new System.Drawing.Size(591, 430);
            this.schedulerControl1.Start = new System.DateTime(2021, 2, 18, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 9;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00");
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.MonthView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.Enabled = false;
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl1.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl1_PopupMenuShowing);
            this.schedulerControl1.CustomDrawDayHeader += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.schedulerControl1_CustomDrawDayHeader);
            this.schedulerControl1.CustomDrawDayViewAllDayArea += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.schedulerControl1_CustomDrawDayViewAllDayArea);
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Id = 0;
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToFullWeekViewItem1
            // 
            this.switchToFullWeekViewItem1.Id = 1;
            this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Id = 2;
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.barDockControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.barDockControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.barDockControl1.Appearance.Options.UseBackColor = true;
            this.barDockControl1.Appearance.Options.UseBorderColor = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(675, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 488);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(675, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 464);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(675, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 464);
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Id = 3;
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Id = 4;
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToTimelineViewItem1
            // 
            this.switchToTimelineViewItem1.Id = 5;
            this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
            // 
            // switchToGanttViewItem1
            // 
            this.switchToGanttViewItem1.Id = 6;
            this.switchToGanttViewItem1.Name = "switchToGanttViewItem1";
            // 
            // switchToAgendaViewItem1
            // 
            this.switchToAgendaViewItem1.Id = 7;
            this.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1";
            // 
            // switchToYearViewItem1
            // 
            this.switchToYearViewItem1.Id = 8;
            this.switchToYearViewItem1.Name = "switchToYearViewItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Id = 9;
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Id = 10;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Id = 11;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Id = 12;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // switchShowWorkTimeOnlyItem1
            // 
            this.switchShowWorkTimeOnlyItem1.Id = 13;
            this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
            // 
            // switchCellsAutoHeightItem1
            // 
            this.switchCellsAutoHeightItem1.Id = 14;
            this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
            // 
            // changeSnapToCellsUIItem1
            // 
            this.changeSnapToCellsUIItem1.Id = 15;
            this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToFullWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToTimelineViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToGanttViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToAgendaViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToYearViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController1.BarItems.Add(this.changeScaleWidthItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController1.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCellsAutoHeightItem1);
            this.schedulerBarController1.BarItems.Add(this.changeSnapToCellsUIItem1);
            this.schedulerBarController1.Control = this.schedulerControl1;
            // 
            // activeViewBar1
            // 
            this.activeViewBar1.BarName = "";
            this.activeViewBar1.Control = null;
            this.activeViewBar1.DockCol = 0;
            this.activeViewBar1.DockRow = 0;
            this.activeViewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.activeViewBar1.Offset = 474;
            this.activeViewBar1.Text = "";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(675, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(675, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 464);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(675, 24);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 464);
            // 
            // layoutBar1
            // 
            this.layoutBar1.BarName = "";
            this.layoutBar1.Control = null;
            this.layoutBar1.DockCol = 1;
            this.layoutBar1.DockRow = 1;
            this.layoutBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.layoutBar1.Text = "";
            // 
            // timeScaleBar1
            // 
            this.timeScaleBar1.BarName = "";
            this.timeScaleBar1.Control = null;
            this.timeScaleBar1.DockCol = 0;
            this.timeScaleBar1.DockRow = 1;
            this.timeScaleBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.timeScaleBar1.Text = "";
            // 
            // layoutBar2
            // 
            this.layoutBar2.BarName = "";
            this.layoutBar2.Control = null;
            this.layoutBar2.DockCol = 1;
            this.layoutBar2.DockRow = 1;
            this.layoutBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.layoutBar2.Text = "";
            // 
            // timeScaleBar2
            // 
            this.timeScaleBar2.BarName = "";
            this.timeScaleBar2.Control = null;
            this.timeScaleBar2.DockCol = 0;
            this.timeScaleBar2.DockRow = 1;
            this.timeScaleBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.timeScaleBar2.Text = "";
            // 
            // form_calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(675, 488);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_calendar";
            this.Text = "Takvim";
            this.Load += new System.EventHandler(this.form_calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraScheduler.UI.ActiveViewBar activeViewBar1;
        private DevExpress.XtraScheduler.UI.LayoutBar layoutBar1;
        private DevExpress.XtraScheduler.UI.TimeScaleBar timeScaleBar1;
        private DevExpress.XtraScheduler.UI.LayoutBar layoutBar2;
        private DevExpress.XtraScheduler.UI.TimeScaleBar timeScaleBar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraScheduler.UI.ActiveViewBar activeViewBar2;
        private DevExpress.XtraScheduler.UI.SwitchToDayViewItem switchToDayViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToMonthViewItem switchToMonthViewItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWeekViewItem switchToWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToGanttViewItem switchToGanttViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem switchToAgendaViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToYearViewItem switchToYearViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesItem switchTimeScalesItem1;
        private DevExpress.XtraScheduler.UI.ChangeScaleWidthItem changeScaleWidthItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
        private DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
        private DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
        private DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}