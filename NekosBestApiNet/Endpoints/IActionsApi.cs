#region

using System.Threading.Tasks;
using NekosBestApiNet.Models.Images;
using Refit;

#endregion

namespace NekosBestApiNet.Endpoints;

/// <summary>
///     Actions like poke, hug, or cuddle, even (LEWD!) kiss!
/// </summary>
public interface IActionsApi
{
    /// <summary>
    ///     Madge.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/angry")]
    public Task<ActionResult> Angry(int results = 1);

    /// <summary>
    ///     y-you should know what this does if you're using this! Baka!
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/baka")]
    public Task<ActionResult> Baka(int results = 1);

    /// <summary>
    ///     Nom! Returns one or more bite gifs!
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/bite")]
    public Task<ActionResult> Bite(int results = 1);

    /// <summary>
    ///     *blushes* will you be mine? Returns a blush image
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/blush")]
    public Task<ActionResult> Blush(int results = 1);

    /// <summary>
    ///     *yawns* Returns a bored gif.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/bored")]
    public Task<ActionResult> Bored(int results = 1);

    /// <summary>
    ///     Too Horny! *bonk* Returns a random bonk image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/bonk")]
    public Task<ActionResult> Bonk(int results = 1);

    /// <summary>
    ///     Returns a kick gif. (Good luck moderation bots, lol)
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/kick")]
    public Task<ActionResult> Kick(int results = 1);

    /// <summary>
    ///     Returns a shoot gif. You won't shoot a kawaii dev like me, right? right?
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/shoot")]
    public Task<ActionResult> Shoot(int results = 1);

    /// <summary>
    ///     Returns a handhold gif (Lewd Monster!).
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/handhold")]
    public Task<ActionResult> Handhold(int results = 1);

    /// <summary>
    ///     Returns a handshake gif.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/handshake")]
    public Task<ActionResult> Handshake(int results = 1);

    /// <summary>
    ///     ~sneak~
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/lurk")]
    public Task<ActionResult> Lurk(int results = 1);

    /// <summary>
    ///     Peck.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/peck")]
    public Task<ActionResult> Peck(int results = 1);

    /// <summary>
    ///     ~yawn~ im doing this in the sleepy morning.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/yawn")]
    public Task<ActionResult> Yawn(int results = 1);

    /// <summary>
    ///     Returns a punch gif. Do an Mike Tyson on em.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/punch")]
    public Task<ActionResult> Punch(int results = 1);

    /// <summary>
    ///     They didn't have any pocky at the store *sob*
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/cry")]
    public Task<ActionResult> Cry(int results = 1);

    /// <summary>
    ///     *cuddles* Returns a cuddle image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/cuddle")]
    public Task<ActionResult> Cuddle(int results = 1);

    /// <summary>
    ///     *Starts dancing furiously* Returns a random dance gif.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/dance")]
    public Task<ActionResult> Dance(int results = 1);

    /// <summary>
    ///     You just posted cringe. Returns a facepalm image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/facepalm")]
    public Task<ActionResult> Facepalm(int results = 1);

    /// <summary>
    ///     Im hungry... Returns a random feed image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/feed")]
    public Task<ActionResult> Feed(int results = 1);

    /// <summary>
    ///     "happy squealing" Returns a random happy image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/happy")]
    public Task<ActionResult> Happy(int results = 1);

    /// <summary>
    ///     High-five for getting this far without having a stroke! Returns a random high-five image
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/highfive")]
    public Task<ActionResult> Highfive(int results = 1);

    /// <summary>
    ///     You look like you need one. Returns a random hug image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/hug")]
    public Task<ActionResult> Hug(int results = 1);

    /// <summary>
    ///     l-lewd! Returns a random kiss image
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/kiss")]
    public Task<ActionResult> Kiss(int results = 1);

    /// <summary>
    ///     *giggles* you funny! Returns a random laugh image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/laugh")]
    public Task<ActionResult> Laugh(int results = 1);

    /// <summary>
    ///     *nods* Returns a random nod image!
    /// </summary>
    /// <param name="results"></param>
    /// <returns>Returns the number of results you want. Defaults to 1.</returns>
    [Get("/nod")]
    public Task<ActionResult> Nod(int results = 1);

    /// <summary>
    ///     *nom* Returns a random nom image.
    /// </summary>
    /// <param name="results"></param>
    /// <returns>Returns the number of results you want. Defaults to 1.</returns>
    [Get("/nom")]
    public Task<ActionResult> Nom(int results = 1);

    /// <summary>
    ///     NOPE im outta here, returns a random nope image
    /// </summary>
    /// <param name="results"></param>
    /// <returns>Returns the number of results you want. Defaults to 1.</returns>
    [Get("/nope")]
    public Task<ActionResult> Nope(int results = 1);


    /// <summary>
    ///     *gives pattus* Returns a random pat image!
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/pat")]
    public Task<ActionResult> Pat(int results = 1);

    /// <summary>
    ///     *aggressive poking* Returns a random poke image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/poke")]
    public Task<ActionResult> Poke(int results = 1);

    /// <summary>
    ///     B-but you said we could get ice cream.. *pouts* Returns a random pout image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/pout")]
    public Task<ActionResult> Pout(int results = 1);

    /// <summary>
    ///     Are these summaries good enough? *shrugs* Returns a random shrug image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/shrug")]
    public Task<ActionResult> Shrug(int results = 1);


    /// <summary>
    ///     *runs away* Returns a random run image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/run")]
    public Task<ActionResult> Run(int results = 1);

    /// <summary>
    ///     *slaps you* Stay back pervert! Returns a random slap image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/slap")]
    public Task<ActionResult> Slap(int results = 1);

    /// <summary>
    ///     I have been doing this for a few hours now, I need sleep. Returns a random sleep image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/sleep")]
    public Task<ActionResult> Sleep(int results = 1);

    /// <summary>
    ///     *smiles* Have a good day! Returns a random smile image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/smile")]
    public Task<ActionResult> Smile(int results = 1);

    /// <summary>
    ///     My bot is like you've never seen, I smugly say. Returns a random smug image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/smug")]
    public Task<ActionResult> Smug(int results = 1);

    /// <summary>
    ///     Jiiiiiiii. Returns a random Stare image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/stare")]
    public Task<ActionResult> Stare(int results = 1);

    /// <summary>
    ///     *(╯°□°)╯︵ ┻━┻* Returns a random table flip image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/tableflip")]
    public Task<ActionResult> TableFlip(int results = 1);

    /// <summary>
    ///     :thonk: Returns a random think image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/think")]
    public Task<ActionResult> Think(int results = 1);

    /// <summary>
    ///     Thumbsup to your current efforts in reading all this! Returns a random thumbsup image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/thumbsup")]
    public Task<ActionResult> Thumbsup(int results = 1);

    /// <summary>
    ///     *tickles* Returns a random tickle image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/tickle")]
    public Task<ActionResult> Tickle(int results = 1);

    /// <summary>
    ///     Hello! *waves* Returns a random wave image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/wave")]
    public Task<ActionResult> Wave(int results = 1);

    /// <summary>
    ///     *winks* We both know what you're thinking about right now. Returns a random wink image.
    ///     <param name="results">Returns the number of results you want. Defaults to 1.</param>
    /// </summary>
    [Get("/wink")]
    public Task<ActionResult> Wink(int results = 1);

    /// <summary>
    ///     This bitch empty, YEEET!, Returns a random yeet image.
    /// </summary>
    /// <param name="results"></param>
    /// <returns></returns>
    [Get("/yeet")]
    public Task<ActionResult> Yeet(int results = 1);
}