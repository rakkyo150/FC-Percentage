﻿using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace FullComboPercentageCounter.Configuration
{
	internal class PluginConfig
	{
#pragma warning disable CS8618
		public static PluginConfig Instance { get; set; }
#pragma warning restore CS8618

		// Shared Settings (Custom Counters+ Counter & Results View)
		public virtual bool IgnoreMultiplier { get; set; } = false;

		// FCPercentageCounter Settings (Custom Counters+ Counter)
		public virtual int DecimalPrecision_Counter { get; set; } = 2;
		public virtual bool KeepTrailingZeros_Counter { get; set; } = true;
		public virtual float PercentageSize { get; set; } = 0.85f;
		public virtual bool EnableLabel_Counter { get; set; } = true;
		public virtual bool LabelAboveCount { get; set; } = false;
		public virtual bool SplitPercentage_Counter { get; set; } = false;
		public virtual bool UseSaberColorScheme_Counter { get; set; } = true;
		// Extra settings available from config file
		public virtual string CounterLabelTextPrefix { get; set; } = "FC : ";
		public virtual string CounterLabelTextAboveCount { get; set; } = "FC Percent";
		public virtual float CounterLabelOffsetAboveCount { get; set; } = 0.32f;
		public virtual float CounterLabelSizeAboveCount { get; set; } = 0.95f;
		public virtual string SplitPercentageSeparatorText_Counter { get; set; } = "  ";


		//FCScorePercentage Settings (Results View)
		public virtual ResultsViewModes ResultsViewMode { get; set; } = ResultsViewModes.OffWhenFullCombo;
		public virtual int DecimalPrecision_ScorePercentage { get; set; } = 2;
		public virtual bool KeepTrailingZeros_ScorePercentage { get; set; } = false;
		public virtual bool EnableScorePercentageDifference { get; set; } = true;
		public virtual bool EnableLabel_ScorePercentage { get; set; } = true;
		public virtual bool SplitPercentage_ScorePercentage { get; set; } = false;
		public virtual bool UseSaberColorScheme_ScorePercentage { get; set; } = true;
		// Extra settings available from config file
		public virtual string ResultScreenScorePrefix { get; set; } = "FC : ";
		public virtual string ResultScreenPercentagePrefix { get; set; } = "FC : ";
		public virtual string SplitPercentageSeparatorText_ScorePercentage { get; set; } = "  ";


		/// <summary>
		/// This is called whenever BSIPA reads the config from disk (including when file changes are detected).
		/// </summary>
		public virtual void OnReload()
		{
			// Do stuff after config is read from disk.
		}

		/// <summary>
		/// Call this to force BSIPA to update the config file. This is also called by BSIPA if it detects the file was modified.
		/// </summary>
		public virtual void Changed()
		{
			// Do stuff when the config is changed.
		}

		/// <summary>
		/// Call this to have BSIPA copy the values from <paramref name="other"/> into this config.
		/// </summary>
		public virtual void CopyFrom(PluginConfig other)
		{
			// This instance's members populated from other
		}
	}

	public enum ResultsViewModes { On, OffWhenFullCombo, Off }
}
