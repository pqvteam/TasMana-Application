using Microsoft.Extensions.Configuration;
using Repositories.Entities;
using Services;

namespace GUIs;

public partial class FindTask : Form
{
    public FindTask()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        GiaoViecService assignTaskService = new GiaoViecService();
        GiaoViec? assignedTask = assignTaskService.findAssignedTask("GD-001.001");
        MessageBox.Show(assignedTask?.MoTaCongViec, assignedTask?.TenCongViec);
    }
}
