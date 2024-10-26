using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace FargoCP.Localization.MasomodeEX.GlobalTranslation
{
    [JITWhenModsEnabled ("MasomodeEX")]
    public class MasomodeEXGlobalTranslation : ModSystem
    {
        public override void Load()
        {
            On_ChatManager.ParseMessage += Translate;            
        }
        public override void Unload()
        {
            On_ChatManager.ParseMessage -= Translate;
        }       
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //看不懂
            text = Regex.Replace(text, "I still have plenty of gimmicks and tricks left!", "");
            text = Regex.Replace(text, "I see that you have annihilated my son!,You wimp!", "");
            text = Regex.Replace(text, "It looks like you can't defeat me!", "");
            text = Regex.Replace(text, "Hehehehehehe! I GUARANTEE YOU DON'T HAVE ENOUGH POWER TO DEFEAT ME!!!", "");
            text = Regex.Replace(text, "Guys, Will you assist me for a moment?", "");
            text = Regex.Replace(text, "I'm going to bring more of my servants to assist me!", "");
            text = Regex.Replace(text, "Go servants, what are you all waiting for?", "");
            text = Regex.Replace(text, "Servants! Get this little peasant out of my sight at once!", "");
            text = Regex.Replace(text, "Mwahahahahahahahahaha! Trap this tiny struggle at once!", "");
            text = Regex.Replace(text, "Ahhhh, My eyes!", "");
            text = Regex.Replace(text, "WHAT ARE YOU DOING TO ME!?! Healing Leech Clots, Recover me at once!", "");
            text = Regex.Replace(text, "was eaten alive by Eater of Souls.", "");
            text = Regex.Replace(text, "was eaten alive by Eater of Worlds.", "");
            text = Regex.Replace(text, "was eaten alive by The Destroyer.", "");
            text = Regex.Replace(text, "YOU THINK YOU CAN BUTCHER A GREAT LORD!?!", "");
            text = Regex.Replace(text, "Mutant has been enraged by the death of his brother!", "");
            text = Regex.Replace(text, "Mutant has been enraged by the death of his sister!", "");
            text = Regex.Replace(text, "Mutant has been enraged!", "");
            text = Regex.Replace(text, "Ahhhhh! It was a mistake to cum here!", "");
            text = Regex.Replace(text, "The enemy souls are possessed by ethereal spirits...", "");
            text = Regex.Replace(text, "What you're doing is a crime against the universe, mortal.", "");
            text = Regex.Replace(text, "Play a real game mode, would you? Not this... thing.", "");
            text = Regex.Replace(text, "Mutant has been enraged by the abduction of his sister!", "");
            text = Regex.Replace(text, "Guys, Will you assist me for a moment?", "");
            text = Regex.Replace(text, "I'm going to bring more of my servants to assist me!", "");
            text = Regex.Replace(text, "Go servants, what are you all waiting for?", "");
            text = Regex.Replace(text, "Servants! Get this little peasant out of my sight at once!", "");
            text = Regex.Replace(text, "Mwahahahahahahahahaha! Trap this tiny struggle at once!", "");

            //月亮领主文本

            text = Regex.Replace(text, "Your fate has been sealed...", "");
            text = Regex.Replace(text, "A godly fate approaches your essence...", "");
            text = Regex.Replace(text, "Well well well, You spawned me! How could you!?!", "");
            text = Regex.Replace(text, "If you keep doing this to me, You have Cthulhu to contend with!", "");
            text = Regex.Replace(text, "Guess who's back, that's right it's me! Mwahahahahahaha!", "");
            text = Regex.Replace(text, "Ugh, not again!", "");
            text = Regex.Replace(text, "Aaahhh, What are you even doing to me?", "");
            text = Regex.Replace(text, "Not my heart!", "");
            text = Regex.Replace(text, "Why are you ever attacking me ignorantly?", "");
            text = Regex.Replace(text, "Grrrrrr! What are you doing to me you little peasant!?!", "");
            text = Regex.Replace(text, "Owwwww!! HELP ME!! I'm getting badly hurt by this little struggle!!", "");
            text = Regex.Replace(text, "NOOOOOO! Stop trying to defeat me you silly little peasant!!!", "");
            text = Regex.Replace(text, "THAT'S IT!!! I'LL JUST REGENERATE MORE HEALTH EVERY SECOND!!!!!!", "");
            text = Regex.Replace(text, "GGRRRRR!!!! ARE YOU DONE ATTACKING ME YET!?!?!", "");
            text = Regex.Replace(text, "SURRENDER NOW!", "");
            text = Regex.Replace(text, "THIS IS MY LAST ATTACK -- MY TRUMP CARD AS LIBTARDS WOULD SAY. SURRENDER NOW OR FACE MY GAMER DAB!", "");
            text = Regex.Replace(text, "This isn’t over!", "");
            text = Regex.Replace(text, "The Grand Hero will fall, Hahahahahaha!!!", "");
            text = Regex.Replace(text, "Do you know how I obtained my power? Oh, you don't know the strength I hold? Well here you go!!", "");
            text = Regex.Replace(text, "THE OCTOPUS GOD RULES THE DEPTHS, THE TWINS RULE THE SKIES. BUT I, THE GREAT EARTH LORD, RULE THE EARTH ITSELF!!!", "");
            text = Regex.Replace(text, "Weakling!!", "");
            text = Regex.Replace(text, "You can’t even survive them! What hope do you have against me!?", "");

            //突变体文本

            text = Regex.Replace(text, "Big mistake, kid. You'll pay for that.", "");
            text = Regex.Replace(text, "Back for more? Really now.", "");
            text = Regex.Replace(text, "You really like going through hell don't you? Have it your way.", "");
            text = Regex.Replace(text, "You brought this upon yourself. I'll just have to keep ripping you to bloody pieces.", "");
            text = Regex.Replace(text, "Luck won't help you here. I'm barely responsive to prayers.", "");
            text = Regex.Replace(text, "You have some real commitment... to being a wretched fool, that is.", "");
            text = Regex.Replace(text, "Nothing's sticking. It's no use, TAKE THIS!", "");
            text = Regex.Replace(text, "I bore of dealing with you. Focus, slow down.", "");
            text = Regex.Replace(text, "Give my brother a break, damn it.", "");
            text = Regex.Replace(text, "Honestly, the guide deserved this, but not us.", "");
            text = Regex.Replace(text, "This is just getting ridiculous...", "");
            text = Regex.Replace(text, "I’ll make you suffer for an eternity. You deserve as much. Die over and over again until you break in rage and insanity.", "");
            text = Regex.Replace(text, "Ech.", "");
            text = Regex.Replace(text, "I could recite all the digits of Pi before you beat me.", "");
            text = Regex.Replace(text, "Not even the Great Tyrant is a worthy opponent.", "");
            text = Regex.Replace(text, "The eroded spirits have failed... Yet, you will still fail against me.", "");
            text = Regex.Replace(text, "This is just the beginning of true hell.", "");
            text = Regex.Replace(text, "No matter how well you use your weapons, the result, still, will not be in your favor.", "");
            text = Regex.Replace(text, "This fight is already impossible... you think it'll be over that easily?", "");
            text = Regex.Replace(text, "So this is the rampage that killed the Moon Lord...", "");
            text = Regex.Replace(text, "This is barely the beginning!", "");
            text = Regex.Replace(text, "Power is in the eye of the beholder. Absolute power is a fact.", "");
            text = Regex.Replace(text, "Never has else anyone advanced as much as you... there can only be one.", "");
            text = Regex.Replace(text, "This has dragged on too long... prepare for my unbound power.", "");
            text = Regex.Replace(text, "The tyrant and the witch failed to stop you. No matter, you'll end here.", "");
            text = Regex.Replace(text, "Fall beneath the emissary of justice, kid.", "");
            text = Regex.Replace(text, "There’s so much blood on your hands...", "");
            text = Regex.Replace(text, "I may be a mutant, but thank Terry I’m no pushover.", "");
            text = Regex.Replace(text, "Still not worthy, but these are tough times... no longer on your side.", "");
            text = Regex.Replace(text, "Savagery, barbarism, bloodthirst... you have too much.", "");
            text = Regex.Replace(text, "Don’t tell me I’m not creative, the other guy's purple!", "");
            text = Regex.Replace(text, "I shouldn’t have let you buy in bulk.", "");
            text = Regex.Replace(text, "WHY AREN’T YOU DEAD?! FACE TRUE HELL!!!", "");
            text = Regex.Replace(text, "YOU ARE POWERLESS, HERO.", "");
            text = Regex.Replace(text, "ALL YOU FOUGHT FOR WILL BE LOST IN THE INFINITE ABYSS!!!!", "");
            text = Regex.Replace(text, "FALL BENEATH MY FIERY WRATH, FOOLISH HERO! THE ABYSS CONSUMES ALL!", "");
            text = Regex.Replace(text, "At least I'll get to see my brother again...", "");
            text = Regex.Replace(text, "With some luck, maybe my brother can catch a break...", "");
            text = Regex.Replace(text, "Cut me some slack...", "");
            text = Regex.Replace(text, "Now do it without getting hit.", "");
            text = Regex.Replace(text, "Showoff... now do it with a copper shortsword.", "");
            text = Regex.Replace(text, "How annoying.", "");
            text = Regex.Replace(text, "By the way, I'm out of death text now.", "");
            text = Regex.Replace(text, "Now. Prepare to wish death as to your escape in suffering.", "");
            text = Regex.Replace(text, "Just try to harm me. Your pathetic peashooters have proven nothing!", "");
            text = Regex.Replace(text, "I've watched your journey...", "");
            text = Regex.Replace(text, "I've seen you fail.", "");
            text = Regex.Replace(text, "Eviscerate under my hands!", "");
            text = Regex.Replace(text, "Die, you rat!", "");
            text = Regex.Replace(text, "How long can you survive?", "");
            text = Regex.Replace(text, "No... it can't... be... How could I fall... to a mere human...", "");
            text = Regex.Replace(text, "Foolish Terrarian. Your powers aren't even 28.5714 percent as strong as mine. Witness a true cataclysm. THIS ISN'T EVEN MY FINAL FORM!", "");
            text = Regex.Replace(text, "Still think this move is that bad?", "");
            text = Regex.Replace(text, "Fall beneath true power!", "");
            text = Regex.Replace(text, "Don't even try to dodge!", "");
            text = Regex.Replace(text, "He who watches only gains suffering.", "");
            text = Regex.Replace(text, "Thought you had a hard enough time dodging one?", "");
            text = Regex.Replace(text, "Such a beautiful day outside, isn't it?", "");
            text = Regex.Replace(text, "You know, I was that", "");
            text = Regex.Replace(text, "watching...", "");
            text = Regex.Replace(text, "Fall beneath true power!", "");
            text = Regex.Replace(text, "Don't even try to dodge!", "");
            text = Regex.Replace(text, "Worm bosses... worm everywhere.", "");
            text = Regex.Replace(text, "Exterminating the weak is a hobby of mine.", "");
            text = Regex.Replace(text, "Time to light it up!", "");
            text = Regex.Replace(text, "Now this is how we use our HEADS. Is this a bad enough time for you!?", "");
            text = Regex.Replace(text, "ASSIST ME, FELLOW MUTANTS!", "");
            text = Regex.Replace(text, "I've watched your journey...", "");
            text = Regex.Replace(text, "And now it's time to light you up!", "");
            text = Regex.Replace(text, "Lovely weather, isn't it?", "");
            text = Regex.Replace(text, "ASSIST ME, FELLOW MUTANTS!", "");
            text = Regex.Replace(text, "Lovely weather, isn't it?", "");
            text = Regex.Replace(text, "Burn in hell!", "");
            text = Regex.Replace(text, "Exterminating the weak is a hobby of mine.", "");
            text = Regex.Replace(text, "This'll leave a few Marx.", "");
            text = Regex.Replace(text, "THE ABYSS CONSUMES ALL!", "");
            text = Regex.Replace(text, "RAGNAROK WILL END YOUR CHILDISH RAMPAGE!", "");
            text = Regex.Replace(text, "YOU WILL BE BURNED AS THE SUNKEN SEA WAS!", "");
            text = Regex.Replace(text, "THE TRUE FURY OF THE TYRANT WILL ANNIHILATE YOUR TINY POWER!", "");
            text = Regex.Replace(text, "YOU ARE NOTHING COMPARED TO THE ERODED SPIRITS!", "");
            text = Regex.Replace(text, "I BRING FORTH THE END UPON THE FOOLISH, THE UNWORTHY!", "");
            text = Regex.Replace(text, "YOU WANT TO DEFEAT ME?", "");
            text = Regex.Replace(text, "MAYBE IN TWO ETERNITIES!", "");
            text = Regex.Replace(text, "DIE, FOOLISH TERRARIAN!", "");
            text = Regex.Replace(text, "THEY SAID THERE WAS 3 END BRINGERS...", "");
            text = Regex.Replace(text, "BUT I AM THE FOURTH, A BREAKER OF REALITY!", "");
            text = Regex.Replace(text, "HELL DOESN’T ACCEPT SCUM LIKE YOU, SO SUFFER FOREVER IN MY ENDLESS ONSLAUGHT!", "");
            text = Regex.Replace(text, "MY INFINITE POWER!!", "");
            text = Regex.Replace(text, "THE POTENTIAL OF ETERNITIES STRETCHED TO THE ABSOLUTE MAXIMUM APOTHEOSES!", "");
            text = Regex.Replace(text, "YOUR UNHOLY SOUL SHALL BE CONSUMED BY DEPTHS LOWER THAN THE DEEPEST REACHES OF HELL!", "");
            text = Regex.Replace(text, "I CONTROL THE POWER THAT HAS REACHED FROM THE FAR ENDS OF THE UNIVERSE!", "");
            text = Regex.Replace(text, "UNITING DIMENSIONS, MANIPULATING TERRARIA, SLAYING MASOCHIST, AND JUDGING HEAVENS!!!", "");
            text = Regex.Replace(text, "FOR CENTURIES I HAVE TRAINED FOR ONE GOAL ONLY:", "");
            text = Regex.Replace(text, "PURGE THE WORLD OF THE UNWORTHY, SLAY THE WEAK, AND BRING FORTH TRUE POWER.", "");
            text = Regex.Replace(text, "IN THE HIGHEST REACHES OF HEAVEN, MY BROTHER RULES OVER THE SKY!", "");
            text = Regex.Replace(text, "SOON, ALL OF TERRARIA WILL BE PURGED OF THE UNWORTHY AND A NEW AGE WILL START!", "");
            text = Regex.Replace(text, "A NEW AGE OF AWESOME!", "");
            text = Regex.Replace(text, "A GOLDEN AGE WHERE ONLY ABSOLUTE BEINGS EXIST!", "");
            text = Regex.Replace(text, "DEATH, INFERNO, TIDE; I AM THE OMEGA AND THE ALPHA, THE BEGINNING, AND THE END!", "");
            text = Regex.Replace(text, "ALMIGHTY POWER; REVELATIONS.", "");
            text = Regex.Replace(text, "ABSOLUTE BEING, ABSOLUTE PURITY.", "");
            text = Regex.Replace(text, "WITHIN THE FOOLISH BANTERINGS OF THE MORTAL WORLD I HAVE ACHIEVED POWER!", "");
            text = Regex.Replace(text, "POWER THAT WAS ONCE BANISHED TO THE EDGE OF THE GALAXY!", "");
            text = Regex.Replace(text, "I BRING FORTH CALAMITIES, CATASTROPHES, AND CATACLYSM;", "");
            text = Regex.Replace(text, "ELDRITCH POWERS DERIVED FROM THE ABSOLUTE WORD OF FATE.", "");
            text = Regex.Replace(text, "FEEL MY UBIQUITOUS WRATH DRIVE YOU INTO THE GROUND!", "");
            text = Regex.Replace(text, "JUST AS A WORLD SHAPER DRIVES HIS WORLD INTO REALITY!", "");
            text = Regex.Replace(text, "THE SHARPSHOOTER’S EYE PALES IN COMPARISON OF MY PERCEPTION OF REALITY!", "");
            text = Regex.Replace(text, "THE BERSERKER'S RAGE IS NAUGHT BUT A BUNNY'S BEFORE MINE!", "");
            text = Regex.Replace(text, "THE OLYMPIANS ARE MERE LESSER GODS COMPARED TO MY IMMEASURABLE MIGHT!", "");
            text = Regex.Replace(text, "THE ARCH WIZARD'S A POSER, A HACK, A PARLOUR TRICK TOTING JOKER!", "");
            text = Regex.Replace(text, "A MASTERY OF FLIGHT AND THE IRON WILL OF A COLOSSUS ARE BOTH ELEMENTARY CONCEPTS!", "");
            text = Regex.Replace(text, "A CONJURER IS BUT A PEDDLING MAGICIAN!", "");
            text = Regex.Replace(text, "A TRAWLER IS BUT A SLIVER COMPARED TO MY LIFE MASTERY!", "");
            text = Regex.Replace(text, "SUPERSONIC SPEED, LIGHTSPEED TIME!", "");
            text = Regex.Replace(text, "GLORIOUS LIGHT SHALL ELIMINATE YOU, YOU FOOLISH BUFFOON!", "");
            text = Regex.Replace(text, "WHAT ARE YOUR TRUE INTENTIONS?", "");
            text = Regex.Replace(text, "WHY DO YOU REALLY EVEN NEED THIS POWER?", "");
            text = Regex.Replace(text, "WHAT IS THE POINT IN ALL OF THIS!?", "");
            text = Regex.Replace(text, "TO THINK YOU WERE SATISFIED WITH THE PROSPERITY OF THIS LAND!", "");
            text = Regex.Replace(text, "SAFETY AMONGST THE TOWN, PROTECTION OF THE EVIL THREATS, BUT NO!", "");
            text = Regex.Replace(text, "YOU WANTED MORE!", "");
            text = Regex.Replace(text, "YOU JUST WANTED TO SPITE ME, DIDN’T YOU!?", "");
            text = Regex.Replace(text, "ENOUGH OF THIS!", "");
            text = Regex.Replace(text, "I CAN’T KEEP GOING MUCH LONGER!", "");
            text = Regex.Replace(text, "YOU CANNOT KILL ME, THIS IS JUST THE ACT OF AN INSIGNIFICANT LUNATIC!", "");
            text = Regex.Replace(text, "I WILL SOON RETURN FOR ANOTHER BATTLE!", "");
            text = Regex.Replace(text, "THIS IS ONLY THE BEGINNING!", "");
            text = Regex.Replace(text, "DO YOU HONESTLY THINK YOU CAN SURVIVE ANY LONGER?", "");
            text = Regex.Replace(text, "POWER IS IN THE EYE OF THE BEHOLDER!", "");
            text = Regex.Replace(text, "YOU ARE NOT DESERVING OF TRUE DIVINITY!", "");
            text = Regex.Replace(text, "I SHOULD KNOW FROM THE COUNTLESS YOU HAVE SLAUGHTERED!", "");
            text = Regex.Replace(text, "YOUR MOTIVATION IS UNFOUNDED!", "");
            text = Regex.Replace(text, "ALL YOU SEEK IS THE DESTRUCTION OF ANYONE WHO POSES A THREAT TO YOU!", "");
            text = Regex.Replace(text, "THAT’S WHY YOU LIMP ON THIS MOIST ROCK!", "");
            text = Regex.Replace(text, "SEARCHING FOR STICKS AND PEBBLES TO ELIMINATE THE FEARS YOU CANNOT TRULY OVERCOME!", "");
            text = Regex.Replace(text, "IT REALLY SURPRISES ME THAT IT TOOK YOU AWHILE TO REACH THIS POINT!", "");
            text = Regex.Replace(text, "ESPECIALLY GIVEN HOW WELL YOU LEECH OFF YOUR OPPONENTS AFTER BARELY SCRAPING BY!", "");
            text = Regex.Replace(text, "THAT’S HOW YOU WIN ALL YOUR BATTLES, AM I RIGHT!?", "");
            text = Regex.Replace(text, "IT’S HONESTLY IMPRESSIVE THAT YOU’VE MADE IT THIS FAR.", "");
            text = Regex.Replace(text, "I HOPE YOU WEREN’T USING GODMODE, PATHETIC COWARD!", "");
            text = Regex.Replace(text, "YOU MUST BE SO NERVOUS THAT YOU’RE SO CLOSE!", "");
            text = Regex.Replace(text, "I HOPE YOU CHOKE, AND I HOPE YOU CHOKE ON THE ASH AND BLOOD OF YOUR SINS TOO!", "");
            text = Regex.Replace(text, "GLORIOUS LIGHT SHALL ELIMINATE YOU, YOU FOOLISH BUFFOON!", "");
            text = Regex.Replace(text, "AAAAAAAAAAAAA!", "");
            text = Regex.Replace(text, "THIS IS IT!", "");
            text = Regex.Replace(text, "NOW LET'S GET TO THE GOOD PART!!!!!", "");

            return orig.Invoke(text, baseColor);
        }       
    }
}
