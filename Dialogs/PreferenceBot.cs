using System;
using System.Threading.Tasks;
using Sytem.Linq;
using Microsft.Bot.Builder.Luis;
using Microsft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Net.Http;

namespace Microsoft.Bot.Sample.SimpleEchoBot
{
	[LuisModel("ac8a29cf-3256-4e7f-bb97-623e7d9396af","c9ade14249004580b62f6f4405f91ddb")]
	[Serializable]
    public class PreferenceBot : LuisDialog<object>
    {
		[LuisIntent("")]
		public async Task None(IDialogContext context, LuisResult result){\
			string count = "";
			string message = $"Sorry I didn't understand: {count}" + string.Join(",", result.Intents.Select(i=> i.Intent));
			await context.PostAsync(message);
			context.Wait(MessageReceived);  
		}
		
		[LuisIntent("Hello")]
		public async Task None(IDialogContext context, LuisResult result){
			string message = $"Hi. How can I help you today?");
			await context.PostAsync(message);
			context.Wait(MessageReceived);  
		}
		
		public PreferenceBot()
		{
			
		}
		public PreferenceBot(ILuisService service): base(service)
		{
			
		}
	}
}