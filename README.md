Opdracht 1 Functions, Methods, Parameters & return type

ik heb er voor gezorgd dat er allemaal verschillende kleuren balletjes spawnen

technische uitdaging was de opdracht in het algemeen

![prog 1](https://github.com/user-attachments/assets/69f45b2d-d946-4b14-9350-c33a85530178)

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Ballspawner

Opdracht 2 Class, Object, Constructor & Instantiate

technische uitdaging was de opdracht in het algemeen

![prog 2](https://github.com/user-attachments/assets/abb81098-2410-436f-ab67-d9abb9f9d566)

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Tower

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/TowerSpawner

Opdracht 3 List en loop

technische uitdaging was de opdracht in het algemeen

![prog 3](https://github.com/user-attachments/assets/f455f522-5084-41b4-9ead-0d108a327799)

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Enemy

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Enemyspawner

Opdracht 4: Action Events

technische uitdaging was de opdracht in het algemeen

![prog 4](https://github.com/user-attachments/assets/1ddd8089-2891-4622-be39-cb5cfbfbdce8)

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Pickup

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Playermovement

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Scoreboard

Opdracht 6: SRP

<img width="652" height="284" alt="image" src="https://github.com/user-attachments/assets/5a386309-d04d-41e0-bbcc-c0acddb59775" />

technische uitdaging was het clonen van de repo

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Laserbehavior

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Shipbehaviour

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Shipinventory

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Shipmovement

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Shipshooting

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/ShipUI


M6 
Opdracht 1: Code conventions

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Inventory%20item

https://github.com/Flyboyace/Prog-opdrachten-M5/blob/main/Weapon



Opdracht 2: Class Diagram van je TD project

```mermaid
classDiagram
    class BaseHealth {
        -int baseHealth
        -Slider healthBar
        +RemoveHealth(int health) void
        -Checkhealth() void
    }

    class PlayerHealth {
        -float health
        +Damage(float damage) void
    }

    class DamagePlayer {
        -PlayerHealth playerHealth
        +DamPlayer() void
    }

    class enemyHealth {
        -float health
        -int moneyAdded
        -TextMeshProUGUI healthTxt
        +SetHealth(float i) void
        +TakeHealth(float i) void
        -CheckHealth() void
    }

    class WaypointFollower {
        -List~Transform~ waypoints
        -float speed
        -WaypointHolder waypointHolder
        -int currentWaypointIndex
        -float initialSpeed
        +slowdownEnemy() IEnumerator
    }

    class WaypointHolder {
        -List~Transform~ wayPoints
        +GetWaypoints() List~Transform~
    }

    class Tower {
        -GameObject projectilePrefab
        -float shootInterval
        -float range
        -Transform target
        +bool isPlaced
        -FindTarget() void
        -LookAtTarget(Transform target) void
        -Shoot() IEnumerator
    }

    class TowerStatus {
        +int cost
    }

    class TowerPlacement {
        -Camera mainCamera
        -List~GameObject~ towerPrefabs
        -Currency currency
        -RemoveTower removeTower
        -GameObject currentTower
        -bool isPlacingTower
        +int towerAmount
        +TowerButton(int towerIndex) void
        -StartPlacingTower(int towerIndex) void
        -FollowMouseWithTower() void
        -PlaceTower() void
    }

    class RemoveTower {
        -Button sellButton
        -List~Transform~ towerList
        -Currency currency
        -TowerPlacement placement
        -SellTowers() void
    }

    class Projectile {
        -Transform target
        -float speed
        -float maxRange
        -int damage
        -bool slowdowneffect
        -Vector3 startPosition
        -OnTriggerEnter2D(Collider2D other) void
    }

    class Currency {
        -TextMeshProUGUI m_CurrencyText
        +int Money
        +AddMoney(int money) void
        +RemoveMoney(int money) void
    }

    class WaveManager {
        -Wave[] waves
        -float timeBetweenWaves
        -EnemySpawner spawner
        -int currentWave
        -float countdown
        +int enemiesAlive
    }

    class Wave {
        +int count
        +float rate
    }

    class EnemySpawner {
        -WaveManager waveManager
        -GameObject enemyPrefab
        +SpawnEnemies(int count, float rate) IEnumerator
    }

    class Shop {
        -GameObject panel
        -Transform shopButton
        -bool lerpShopButton
        -Vector3 lerpPos
        -Vector3 originalPos
        +ShowUi() void
    }

    class Startbutton {
        -Button button
        -startgame() void
    }

    class Quitbutton {
        -Button button
        -startgame() void
    }

    DamagePlayer --> PlayerHealth
    enemyHealth --> Currency
    WaypointFollower --> WaypointHolder
    WaypointFollower --> BaseHealth
    Tower --> Projectile
    TowerPlacement --> TowerStatus
    TowerPlacement --> Currency
    TowerPlacement --> RemoveTower
    RemoveTower --> TowerPlacement
    RemoveTower --> Currency
    Projectile --> enemyHealth
    Projectile --> WaypointFollower
    WaveManager --> EnemySpawner
    EnemySpawner --> WaveManager
    WaveManager --> Wave
```

Link naar TD project voor code.
https://github.com/Flyboyace/BO-tower-defense

Opdracht 3: Data structures



Opdracht 4: Score Collection Game


