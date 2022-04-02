﻿using FCPercentage.FCPCore;
using FCPercentage.FCPResults.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCPercentage.FCPResults.CalculationModels
{
	public class CurrentResultDiffCalculationModel : DiffCalculationModel
	{
		LevelCompletionResults levelCompletionResults;
		public CurrentResultDiffCalculationModel(ScoreManager scoreManager, ResultsSettings resultsSettings, LevelCompletionResults levelCompletionResults) : base(scoreManager, resultsSettings) 
		{
			this.levelCompletionResults = levelCompletionResults;
		}

		public override double TotalPercentageDiff => TotalPercentage - ActualPercentage;
		public override double PercentDiffA => PercentA - ActualPercentage;
		public override double PercentDiffB => PercentB - ActualPercentage;
		public override int TotalScoreDiff => TotalScore - levelCompletionResults.modifiedScore;

		private double ActualPercentage => CalculatePercentage(levelCompletionResults.modifiedScore, scoreManager.MaxScoreTotal);
	}
}
