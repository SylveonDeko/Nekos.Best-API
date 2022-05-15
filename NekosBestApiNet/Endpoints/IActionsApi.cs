using System;
using System.Threading.Tasks;
using Refit;
using NekosBestApiNet.Models.Images;

namespace NekosBestApiNet.Endpoints 
{
    /// <summary>
    /// Actions like poke, hug, or cuddle, even (LEWD!) kiss!
    /// </summary>
    public interface IActionsApi
    {
        /// <summary>
        /// y-you should know what this does if you're using this! Baka!
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/baka")]
        Task<ActionResult> Baka(int results = 1);
        
        /// <summary>
        /// Nom! Returns one or more bite gifs!
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/bite")]
        Task<ActionResult> Bite(int results = 1);
        
        /// <summary>
        /// *blushes* will you be mine? Returns a blush image
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/blush")]
        Task<ActionResult> Blush(int results = 1);
        
        /// <summary>
        /// *yawns* Returns a bored gif.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/bored")]
        Task<ActionResult> Bored(int results = 1);
        
        /// <summary>
        /// Returns a kick gif. (Good luck moderation bots, lol)
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/kick")]
        Task<ActionResult> Kick(int results = 1);
        
        /// <summary>
        /// Returns a shoot gif. You won't shoot a kawaii dev like me, right? right?
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/shoot")]
        Task<ActionResult> Shoot(int results = 1);
        
        /// <summary>
        /// Returns a handhold gif (Lewd Monster!).
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/handhold")]
        Task<ActionResult> Handhold(int results = 1);

        /// <summary>
        /// Returns a punch gif. Do an Mike Tyson on em.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/punch")]
        Task<ActionResult> Punch(int results = 1);
        
        /// <summary>
        /// They didn't have any pocky at the store *sob*
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/cry")]
        Task<ActionResult> Cry(int results = 1);
        
        /// <summary>
        /// *cuddles* Returns a cuddle image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/cuddle")]
        Task<ActionResult> Cuddle(int results = 1);
        
        /// <summary>
        /// *Starts dancing furiously* Returns a random dance gif.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/dance")]
        Task<ActionResult> Dance(int results = 1);
        
        /// <summary>
        /// You just posted cringe. Returns a facepalm image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/facepalm")]
        Task<ActionResult> Facepalm(int results = 1);
        
        /// <summary>
        /// Im hungry... Returns a random feed image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/feed")]
        Task<ActionResult> Feed(int results = 1);
        
        /// <summary>
        /// "happy squealing" Returns a random happy image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/happy")]
        Task<ActionResult> Happy(int results = 1);
        
        /// <summary>
        /// High-five for getting this far without having a stroke! Returns a random high-five image
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/highfive")]
        Task<ActionResult> Highfive(int results = 1);
        
        /// <summary>
        /// You look like you need one. Returns a random hug image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/hug")]
        Task<ActionResult> Hug(int results = 1);
        
        /// <summary>
        /// l-lewd! Returns a random kiss image
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/kiss")]
        Task<ActionResult> Kiss(int results = 1);
        
        /// <summary>
        /// *giggles* you funny! Returns a random laugh image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/laugh")]
        Task<ActionResult> Laugh(int results = 1);
        
        /// <summary>
        /// *gives pattus* Returns a random pat image!
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/pat")]
        Task<ActionResult> Pat(int results = 1);
        
        /// <summary>
        /// *aggressive poking* Returns a random poke image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/poke")]
        Task<ActionResult> Poke(int results = 1);
        
        /// <summary>
        /// B-but you said we could get ice cream.. *pouts* Returns a random pout image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/pout")]
        Task<ActionResult> Pout(int results = 1);
        
        /// <summary>
        /// Are these summaries good enough? *shrugs* Returns a random shrug image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/shrug")]
        Task<ActionResult> Shrug(int results = 1);
        
        /// <summary>
        /// *slaps you* Stay back pervert! Returns a random slap image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/slap")]
        Task<ActionResult> Slap(int results = 1);
        
        /// <summary>
        /// I have been doing this for a few hours now, I need sleep. Returns a random sleep image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/sleep")]
        Task<ActionResult> Sleep(int results = 1);
        
        /// <summary>
        /// *smiles* Have a good day! Returns a random smile image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/smile")]
        Task<ActionResult> Smile(int results = 1);
        
        /// <summary>
        /// My bot is like you've never seen, I smugly say. Returns a random smug image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/smug")]
        Task<ActionResult> Smug(int results = 1);
        
        /// <summary>
        /// Jiiiiiiii. Returns a random Stare image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/stare")]
        Task<ActionResult> Stare(int results = 1);
        
        /// <summary>
        /// :thonk: Returns a random think image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/think")]
        Task<ActionResult> Think(int results = 1);
        
        /// <summary>
        /// Thumbsup to your current efforts in reading all this! Returns a random thumbsup image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/thumbsup")]
        Task<ActionResult> Thumbsup(int results = 1);
        
        /// <summary>
        /// *tickles* Returns a random tickle image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/tickle")]
        Task<ActionResult> Tickle(int results = 1);
        
        /// <summary>
        /// Hello! *waves* Returns a random wave image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/wave")]
        Task<ActionResult> Wave(int results = 1);
        
        /// <summary>
        /// *winks* We both know what you're thinking about right now. Returns a random wink image.
        /// <param name="results">Returns the number of results you want. Defaults to 1.</param>
        /// </summary>
        [Get("/wink")]
        Task<ActionResult> Wink(int results = 1);
    }
}