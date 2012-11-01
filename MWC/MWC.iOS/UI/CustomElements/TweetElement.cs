using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using System.Drawing;
using MWC.BL;


namespace MWC.iOS.UI.CustomElements {
	/// <summary>
	/// Renders a Tweet
	/// </summary>
	/// <remarks>
	/// Originally implemented IElementSizing.GetHeight in this class, however
	/// the variable height was not returned after pull-to-refresh (MT.D bug?)
	/// This was fixed by moving the implementation to TwitterScreenSizingSource
	/// </remarks>
	public class TweetElement : Element  {
		static NSString cellId = new NSString ("TweetElement");
	


		public override void Selected (DialogViewController dvc, UITableView tableView, MonoTouch.Foundation.NSIndexPath path)
		{
			var tds = new MWC.iOS.Screens.iPhone.Twitter.TweetDetailsScreen (tweet);
			
			if (splitView != null)
				splitView.ShowTweet(tweet.ID, tds);
			else
				dvc.ActivateController (tds);
		}
	}
}