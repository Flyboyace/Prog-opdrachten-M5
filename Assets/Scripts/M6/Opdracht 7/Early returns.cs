public bool IsPlayerReadyToAttack(Player player)
{
    if (player == null)
        return false;

    if (!player.IsAlive)
        return false;

    if (player.AttackCooldown > 0)
        return false;

    if (player.Target == null)
        return false;

    if (!player.Target.IsAlive)
        return false;

    if (Vector3.Distance(player.transform.position, player.Target.transform.position) >= 5f)
        return false;

    bool hasResources =
        (player.Mana >= 20 && player.WeaponEquipped)
        (player.Health > 30 && player.HasBuff("Strength"));

    if (!hasResources)
        return false;

    if (player.IsStunned  player.IsSlowed)
        return false;

    return true;
}