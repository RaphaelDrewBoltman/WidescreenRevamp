using Reloaded.Mod.Interfaces.Structs;
using sonicheroes.guis.widescreenrevamp.Template.Configuration;
using System.ComponentModel;

namespace sonicheroes.guis.widescreenrevamp.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        [DisplayName("Permanent life icon")]
        [Description("Always show life icon in the bottom left corner.")]
        [DefaultValue(true)]
        public bool PermanentLifeIcon { get; set; } = true;


        [DisplayName("HUD style")]
        [Description("Change the action button style.")]
        [DefaultValue("PC")]
        public Styles HUDStyle { get; set; } = Styles.Windows;

        public enum Styles
        {
            Windows,
            GameCube,
            XBOX,
            Dreamcast,
            PlayStation2,
        }
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
