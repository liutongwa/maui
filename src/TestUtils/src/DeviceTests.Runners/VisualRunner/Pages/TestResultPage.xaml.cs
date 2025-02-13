﻿#nullable enable
using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace Microsoft.Maui.TestUtils.DeviceTests.Runners.VisualRunner.Pages
{
	partial class TestResultPage : ContentPage
	{
		public TestResultPage()
		{
			InitializeComponent();

			CopyMessage.Clicked += CopyMessageClicked;
			CopyTrace.Clicked += CopyTraceClicked;
		}

		async void CopyMessageClicked(object? sender, System.EventArgs e)
		{
			await Clipboard.Default.SetTextAsync(ErrorMessage.Text);
		}

		async void CopyTraceClicked(object? sender, System.EventArgs e)
		{
			await Clipboard.Default.SetTextAsync(ErrorTrace.Text);
		}
	}
}