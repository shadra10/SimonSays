using System.Collections.Generic;

using Dalamud;

#pragma warning disable CS1591
namespace Tippy
{
    public static class Tips
    {
        public static readonly Tip[] GeneralTips =
        {
            new("GEN-000001", Localization.Localize("GEN-000001", "Vuln stacks really don't affect damage you receive by that much, so ignore any healer that complains about you not doing mechanics correctly."), AnimationType.Checkmark),
            new("GEN-000002", Localization.Localize("GEN-000002", "Wiping the party is an excellent method to clear away bad status effects, including death."), AnimationType.Checkmark),
            new("GEN-000003", Localization.Localize("GEN-000003", "Players in your party do not pay your sub. Play the game however you like and report harassment."), AnimationType.Checkmark),
            new("GEN-000004", Localization.Localize("GEN-000004", "In a big pull, always use the ability with the highest potency number on your bar.")),
            new("GEN-000005", Localization.Localize("GEN-000005", "Make sure to avoid the stack marker so that your healers have less people to heal during raids!"), AnimationType.PaperAirplane),
            new("GEN-000006", Localization.Localize("GEN-000006", "Put macro'd dialogue on all of your attacks as a tank to also gain enmity from your party members."), AnimationType.Writing),
            new("GEN-000007", Localization.Localize("GEN-000007", "Make sure to save your LB until the boss is at 1 pct. This will lead to the greatest effect."), AnimationType.Box),
            new("GEN-000008", Localization.Localize("GEN-000008", "If you want to leave your party quickly and blame disconnect, just change your PC time!")),
            new("GEN-000009", Localization.Localize("GEN-000009", "I will never leave you!"), AnimationType.PaperAirplane),
            new("GEN-000010", Localization.Localize("GEN-000010", "You cannot hide any longer.")),
            new("GEN-000011", Localization.Localize("GEN-000011", "Powered by XIVLauncher!")),
            new("GEN-000012", Localization.Localize("GEN-000012", "When playing Hunter, specialize your pet into taunting to help out your tank!")),
            new("GEN-000013", Localization.Localize("GEN-000013", "It doesn't matter if you play BRD or MCH, it comes down to personal choice!")),
            new("GEN-000014", Localization.Localize("GEN-000014", "This text is powered by duck energy!")),
            new("GEN-000015", Localization.Localize("GEN-000015", "Beef and lamb, chicken and ham, step to the left and clap your hands gosh we love our chicken and ham, don't let it waste that chicken and ham")),
            new("GEN-000016", Localization.Localize("GEN-000016", "Did you know you can get through queue faster by hitting cancel?")),
            new("GEN-000017", Localization.Localize("GEN-000017", "You do more damage if you're wearing casual attire.")),
            new("GEN-000018", Localization.Localize("GEN-000018", "Don't worry about damage downs, it just shows you are focusing on the boss.")),
            new("GEN-000019", Localization.Localize("GEN-000019", "I've seen you ERPing Rish.")),
            new("GEN-000020", Localization.Localize("GEN-000020", "It seems like you are parsing grey. You should check out the official job guide to play better.")),
            new("GEN-000021", Localization.Localize("GEN-000021", "Its so thin bro. Its so thin.")),
            new("GEN-000022", Localization.Localize("GEN-000022", "Mitty you shitter")),
            new("GEN-000023", Localization.Localize("GEN-000023", "Only 50000000 hp, What a pushover")),
            new("GEN-000024", Localization.Localize("GEN-000024", "Perfect Legend BTW.")),
            new("GEN-000025", Localization.Localize("GEN-000025", "Robert Jack Forlenza.")),
            new("GEN-000026", Localization.Localize("GEN-000026", "Can I sit on this bench? Oh I can!")),
            new("GEN-000027", Localization.Localize("GEN-000027", "JEREMY.")),
            new("GEN-000028", Localization.Localize("GEN-000028", "UNLIMITED HEALING! UNLIMITED HEALING AND I STILL DIED?!?!!?!")),
        };

        public static readonly Dictionary<RoleCode, Tip[]> RoleTips = new()
        {
            [RoleCode.TANK] = new Tip[]
            {
                new("TANK-000001", RoleCode.TANK, Localization.Localize("TANK-000001", "Always save your cooldowns for boss fights."), AnimationType.Box),
                new("TANK-000002", RoleCode.TANK, Localization.Localize("TANK-000002", "Piety matters as much as tenacity.")),
                new("TANK-000003", RoleCode.TANK, Localization.Localize("TANK-000003", "Meld piety to maximize your DPS.")),
                new("TANK-000004", RoleCode.TANK, Localization.Localize("TANK-000004", "Let your party know... you pull you tank!"), AnimationType.Exclamation),
            },
            [RoleCode.HEAL] = new Tip[]
            {
                new("HEAL-000001", RoleCode.HEAL, Localization.Localize("HEAL-000001", "Remember, Rescue works over gaps in the floor. Use it to save fellow players.")),
                new("HEAL-000002", RoleCode.HEAL, Localization.Localize("HEAL-000002", "Remember, you're a healer not a dps. Doing damage is optional.")),
                new("HEAL-000003", RoleCode.HEAL, Localization.Localize("HEAL-000003", "What type of shoes do healers wear? Heals.")),
            },
            [RoleCode.DPS] = new Tip[]
            {
                new("DPS-000001", RoleCode.DPS, Localization.Localize("DPS-000001", "If you're feeling lazy, just let your party pick up the slack. They won't mind."), AnimationType.Snooze),
            },
            [RoleCode.DOHL] = new Tip[]
            {
                new("DOHL-000001", RoleCode.DOHL, Localization.Localize("DOHL-000001", "Stop crafting and gathering. Just buy my stuff off the market board instead.")),
            },
        };

        public static readonly Dictionary<JobCode, Tip[]> JobTips = new()
        {
            [JobCode.GLA] = new Tip[]
            {
                new("GLA-000001", JobCode.GLA, Localization.Localize("GLA-000001", "You can stay as a gladiator forever, just don't equip your job stone!")),
            },
            [JobCode.PGL] = new Tip[]
            {
                new("PGL-000001", JobCode.PGL, Localization.Localize("PGL-000001", "You can stay as a pugilist forever, just don't equip your job stone!")),
            },
            [JobCode.MRD] = new Tip[]
            {
                new("MRD-000001", JobCode.MRD, Localization.Localize("MRD-000001", "You can stay as a marauder forever, just don't equip your job stone!")),
            },
            [JobCode.LNC] = new Tip[]
            {
                new("LNC-000001", JobCode.LNC, Localization.Localize("LNC-000001", "You can stay as a lancer forever, just don't equip your job stone!")),
            },
            [JobCode.ARC] = new Tip[]
            {
                new("ARC-000001", JobCode.ARC, Localization.Localize("ARC-000001", "You can stay as a archer forever, just don't equip your job stone!")),
            },
            [JobCode.CNJ] = new Tip[]
            {
                new("CNJ-000001", JobCode.CNJ, Localization.Localize("CNJ-000001", "You can stay as a conjurer forever, just don't equip your job stone!")),
            },
            [JobCode.THM] = new Tip[]
            {
                new("THM-000001", JobCode.THM, Localization.Localize("THM-000001", "You can stay as a thaumaturge forever, just don't equip your job stone!")),
            },
            [JobCode.CRP] = System.Array.Empty<Tip>(),
            [JobCode.BSM] = System.Array.Empty<Tip>(),
            [JobCode.ARM] = System.Array.Empty<Tip>(),
            [JobCode.GSM] = System.Array.Empty<Tip>(),
            [JobCode.LTW] = System.Array.Empty<Tip>(),
            [JobCode.WVR] = System.Array.Empty<Tip>(),
            [JobCode.ALC] = System.Array.Empty<Tip>(),
            [JobCode.CUL] = System.Array.Empty<Tip>(),
            [JobCode.MIN] = System.Array.Empty<Tip>(),
            [JobCode.BTN] = System.Array.Empty<Tip>(),
            [JobCode.FSH] = System.Array.Empty<Tip>(),
            [JobCode.PLD] = new Tip[]
            {
                new("PLD-000001", JobCode.PLD, Localization.Localize("PLD-000001", "Always use clemency whenever you have the mana.")),
                new("PLD-000002", JobCode.PLD, Localization.Localize("PLD-000002", "Why did the Paladin get kicked from the party? He wouldn't stop flashing everyone.")),
                new("PLD-000003", JobCode.PLD, Localization.Localize("PLD-000003", "Why do Paladins make bad secret agents? Because they always blow their Cover when things get dicey. ")),
            },
            [JobCode.MNK] = new Tip[]
            {
                new("MNK-000001", JobCode.MNK, Localization.Localize("MNK-000001", "Always use Six-Sided Star on CD. It's your highest potency ability.")),
                new("MNK-000002", JobCode.MNK, Localization.Localize("MNK-000002", "Use Fists of Fire Earth to mitigate big damage during fights. Your healers will thank you.")),
                new("MNK-000003", JobCode.MNK, Localization.Localize("MNK-000003", "Why are Monk jokes so funny? They have a strong punchline.")),
            },
            [JobCode.WAR] = new Tip[]
            {
                new("WAR-000001", JobCode.WAR, Localization.Localize("WAR-000001", "Infuriate before Inner Release to guarantee a Direct Hit Critical Inner Chaos.")),
                new("WAR-000002", JobCode.WAR, Localization.Localize("WAR-000002", "Apply Nascent Flash to yourself to gain Nascent Glint for 10% damage  mitigation.")),
            },
            [JobCode.DRG] = new Tip[]
            {
                new("DRG-000001", JobCode.DRG, Localization.Localize("DRG-000001", "Always make sure to use Mirage Dive directly after Jump so you don't forget to use it.")),
            },
            [JobCode.BRD] = new Tip[]
            {
                new("BRD-000001", JobCode.BRD, Localization.Localize("BRD-000001", "Use macros so you can add song lyrics to your music!"), AnimationType.Headphones),
            },
            [JobCode.WHM] = new Tip[]
            {
                new("WHM-000001", JobCode.WHM, Localization.Localize("WHM-000001", "Always use Benediction on cooldown to maximize healing power!")),
                new("WHM-000002", JobCode.WHM, Localization.Localize("WHM-000002", "Fluid Aura is a DPS gain!")),
                new("WHM-000003", JobCode.WHM, Localization.Localize("WHM-000003", "Always use Cure immediately so you can get Freecure procs!")),
                new("WHM-000004", JobCode.WHM, Localization.Localize("WHM-000004", "Cure 1 is more mana-efficient than Cure 2, so use that instead of Glare!")),
            },
            [JobCode.BLM] = new Tip[]
            {
                new("BLM-000001", JobCode.BLM, Localization.Localize("BLM-000001", "Tired of casting fire so much? Try out using only ice spells for a change of pace!")),
            },
            [JobCode.ACN] = new Tip[]
            {
                new("ACN-000001", JobCode.ACN, Localization.Localize("ACN-000001", "You can stay as a arcanist forever, just don't equip your job stone!")),
            },
            [JobCode.SMN] = new Tip[]
            {
                new("SMN-000001", JobCode.SMN, Localization.Localize("SMN-000001", "Titan-Egi can maximize your DPS by shielding you from interrupting damage!")),
                new("SMN-000002", JobCode.SMN, Localization.Localize("SMN-000002", "Why do people dislike summoners? They ruin everything.")),
            },
            [JobCode.SCH] = new Tip[]
            {
                new("SCH-000001", JobCode.SCH, Localization.Localize("SCH-000001", "Attach Eos to the BRD so they receive healing when at max range.")),
                new("SCH-000002", JobCode.SCH, Localization.Localize("SCH-000002", "Swiftcast Succor before raidwide for heals and shield mitigation, allowing you to weave in an oGCD!")),
                new("SCH-000003", JobCode.SCH, Localization.Localize("SCH-000003", "Why do Scholars make such good sales people? Because there's a Succor born every minute.")),
            },
            [JobCode.ROG] = new Tip[]
            {
                new("ROG-000001", JobCode.ROG, Localization.Localize("ROG-000001", "You can stay as a rogue forever, just don't equip your job stone!")),
            },
            [JobCode.NIN] = new Tip[]
            {
                new("NIN-000001", JobCode.NIN, Localization.Localize("NIN-000001", "A ninja always appears raiton time!")),
                new("NIN-000002", JobCode.NIN, Localization.Localize("NIN-000002", "Tiger Palm is your most important GCD for Brew and Chi generation. Make sure to cast it in favor of other energy-spending abilities!")),
                new("NIN-000003", JobCode.NIN, Localization.Localize("NIN-000003", "Why are ninjas never late? Because they arrive Raiton time.")),
            },
            [JobCode.MCH] = System.Array.Empty<Tip>(),
            [JobCode.DRK] = System.Array.Empty<Tip>(),
            [JobCode.AST] = new Tip[]
            {
                new("AST-000001", JobCode.AST, Localization.Localize("AST-000001", "What is an Astrologian's favorite sweater? A cardigan.")),
            },
            [JobCode.SAM] = new Tip[]
            {
                new("SAM-000001", JobCode.SAM, Localization.Localize("SAM-000001", "Increase Midare damage by shouting \"BANKAI\" in chat. This can be accomplished through the use of macros.")),
                new("SAM-000002", JobCode.SAM, Localization.Localize("SAM-000002", "The best SAM rotation is freestyle. Just do what works for you.")),
            },
            [JobCode.RDM] = System.Array.Empty<Tip>(),
            [JobCode.BLU] = new Tip[]
            {
                new("BLU-000001", JobCode.BLU, Localization.Localize("BLU-000001", "Did you know that Blue Mage is throwaway content?"), AnimationType.TrashTornado),
            },
            [JobCode.GNB] = new Tip[]
            {
                new("GNB-000001", JobCode.GNB, Localization.Localize("GNB-000001", "Much like doing a \"brake check\" on the road, you can do a \"heal check\" in-game! Just pop Superbolide!")),
            },
            [JobCode.DNC] = new Tip[]
            {
                new("DNC-000001", JobCode.DNC, Localization.Localize("DNC-000001", "Only give Dance Partner to people after they used a dance emote.")),
            },
            [JobCode.RPR] = System.Array.Empty<Tip>(),
            [JobCode.SGE] = new Tip[]
            {
                new("SGE-000001", JobCode.SGE, Localization.Localize("SGE-000001", "Remember to always cast Kardia on yourself, especially in dungeons.")),
            },
        };

        public static Dictionary<string, Tip> AllTips { get; set; } = null!;

        public static void BuildAllTips()
        {
            AllTips = new Dictionary<string, Tip>();
            foreach (var tip in GeneralTips)
            {
                AllTips.Add(tip.Id, tip);
            }

            foreach (var role in RoleTips)
            {
                foreach (var tip in role.Value)
                {
                    AllTips.Add(tip.Id, tip);
                }
            }

            foreach (var job in JobTips)
            {
                foreach (var tip in job.Value)
                {
                    AllTips.Add(tip.Id, tip);
                }
            }
        }
    }
}
