using System.Threading.Tasks;
using Refit;
using NekosBestApi.Models.Images;

namespace NekosBestApi.Endpoints 
{
    public interface IActionsApi
    {
        [Get("/baka")]
        Task<ActionResult> Baka(int results = 1);
        
        [Get("/bite")]
        Task<ActionResult> Bite(int results = 1);
        
        [Get("/blush")]
        Task<ActionResult> Blush(int results = 1);
        
        [Get("/bored")]
        Task<ActionResult> Bored(int results = 1);
        
        [Get("/cry")]
        Task<ActionResult> Cry(int results = 1);
        
        [Get("/cuddle")]
        Task<ActionResult> Cuddle(int results = 1);
        
        [Get("/dance")]
        Task<ActionResult> Dance(int results = 1);
        
        [Get("/facepalm")]
        Task<ActionResult> Facepalm(int results = 1);
        
        [Get("/feed")]
        Task<ActionResult> Feed(int results = 1);
        
        [Get("/happy")]
        Task<ActionResult> Happy(int results = 1);
        
        [Get("/highfive")]
        Task<ActionResult> Highfive(int results = 1);
        
        [Get("/hug")]
        Task<ActionResult> Hug(int results = 1);
        
        [Get("/kiss")]
        Task<ActionResult> Kiss(int results = 1);
        
        [Get("/laugh")]
        Task<ActionResult> Laugh(int results = 1);
        
        [Get("/pat")]
        Task<ActionResult> Pat(int results = 1);
        
        [Get("/poke")]
        Task<ActionResult> Poke(int results = 1);
        
        [Get("/Pout")]
        Task<ActionResult> Pout(int results = 1);
        
        [Get("/shrug")]
        Task<ActionResult> Shrug(int results = 1);
        
        [Get("/slap")]
        Task<ActionResult> Slap(int results = 1);
        
        [Get("/sleep")]
        Task<ActionResult> Sleep(int results = 1);
        
        [Get("/smile")]
        Task<ActionResult> Smile(int results = 1);
        
        [Get("/smug")]
        Task<ActionResult> Smug(int results = 1);
        
        [Get("/stare")]
        Task<ActionResult> Stare(int results = 1);
        
        [Get("/think")]
        Task<ActionResult> Think(int results = 1);
        
        [Get("/thumbsup")]
        Task<ActionResult> Thumbsup(int results = 1);
        
        [Get("/tickle")]
        Task<ActionResult> Tickle(int results = 1);
        
        [Get("/wave")]
        Task<ActionResult> Wave(int results = 1);
        
        [Get("/wink")]
        Task<ActionResult> Wink(int results = 1);

    }
}