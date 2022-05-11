using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.DamageSystem
{
    /// <summary>
    /// Contains information about a damage Transmitter.
    /// </summary>
    public class DamageInfo
    {
        /// <summary>
        /// Who is causing this damage.
        /// </summary>
        public Damageable Transmitter;

        public float Damage;
        public bool IgnoreInvulnerability = false;
        public bool IgnoreElement = false;

        public DamageInfo()
        {
        }

        public DamageInfo(Damageable transmitter, float damage, bool ignoreInvulnerability)
        {
            this.Transmitter = transmitter;
            this.Damage = damage;
            this.IgnoreInvulnerability = ignoreInvulnerability;
        }

        public DamageInfo(Damageable transmitter, float damage, bool ignoreInvulnerability,
            bool ignoreElement)
        {
            this.Transmitter = transmitter;
            this.Damage = damage;
            this.IgnoreInvulnerability = ignoreInvulnerability;
            this.IgnoreElement = ignoreElement;
        }
    }
}