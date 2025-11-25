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

Opdracht 10: Class Diagram van je TD project

---
Title: Class Diagram Tower Defense
---
classDiagram

class BaseHealth {
    -baseHealth: int
    -healthBar: Slider
    +RemoveHealth(health: int)
    -Checkhealth()
}

class PlayerHealth {
    -health: float
    +Damage(damage: float)
}

class Currency {
    -m_CurrencyText: TextMeshProUGUI
    +Money: int
    +AddMoney(money: int)
    +RemoveMoney(money: int)
}

class enemyHealth {
    -health: float
    -moneyAdded: int
    -healthTxt: TextMeshProUGUI
    +SetHealth(i: float)
    +TakeHealth(i: float)
    -CheckHealth()
}

class WaypointFollower {
    -waypoints: List~Transform~
    +speed: float
    -waypointHolder: WaypointHolder
    -currentWaypointIndex: int
    -initialSpeed: float
    +slowdownEnemy() IEnumerator
}

class WaypointHolder {
    -wayPoints: List~Transform~
    +GetWaypoints() List~Transform~
}

class DamagePlayer {
    -playerHealth: PlayerHealth
    +DamPlayer()
}

class WaveManager {
    +waves: Wave[]
    +timeBetweenWaves: float
    +spawner: EnemySpawner
    +enemiesAlive: int
    -currentWave: int
    -countdown: float
}

class Wave {
    +count: int
    +rate: float
}

class EnemySpawner {
    -waveManager: WaveManager
    -enemyPrefab: GameObject
    +SpawnEnemies(count: int, rate: float) IEnumerator
}

class waveSystem {
    -enemyPrefab: Transform
    -spawnPoint: Transform
    -spawnRate: float
    -enemiesPerWave: List~int~
    -enemyHealthPerWave: List~float~
    -waveTxt: TextMeshProUGUI
    -currentWave: int
    -activeEnemies: List~GameObject~
    +StartNextWave() IEnumerator
}

class Tower {
    -projectilePrefab: GameObject
    -shootInterval: float
    -range: float
    -target: Transform
    +isPlaced: bool
    +Start() IEnumerator
    -FindTarget()
    -LookAtTarget(target: Transform)
    -Shoot() IEnumerator
}

class TowerStatus {
    +cost: int
}

class TowerPlacement {
    -mainCamera: Camera
    -towerPrefabs: List~GameObject~
    -currency: Currency
    -removeTower: RemoveTower
    -currentTower: GameObject
    -isPlacingTower: bool
    +towerAmount: int
    +TowerButton(towerIndex: int)
    -StartPlacingTower(towerIndex: int)
    -FollowMouseWithTower()
    -PlaceTower()
}

class RemoveTower {
    -sellButton: Button
    +towerList: List~Transform~
    -currency: Currency
    -placement: TowerPlacement
    -SellTowers()
}

class Projectile {
    +target: Transform
    -speed: float
    -maxRange: float
    -damage: int
    -slowdowneffect: bool
    -startPosition: Vector3
    +OnTriggerEnter2D(other: Collider2D)
}

class Shop {
    -panel: GameObject
    -shopButton: Transform
    -lerpShopButton: bool
    -lerpPos: Vector3
    -originalPos: Vector3
    +ShowUi()
}

class Startbutton {
    -button: Button
    -startgame()
}

class Quitbutton {
    -button: Button
    -startgame()
}

BaseHealth ..> SceneManager
BaseHealth ..> Slider

PlayerHealth ..> BaseHealth

Currency ..> TextMeshProUGUI

enemyHealth ..> TextMeshProUGUI
enemyHealth ..> Currency

WaypointFollower ..> WaypointHolder
WaypointFollower ..> BaseHealth

WaypointHolder ..> Transform

DamagePlayer ..> PlayerHealth

WaveManager ..> EnemySpawner
WaveManager ..> Wave

EnemySpawner ..> WaveManager
EnemySpawner ..> GameObject

waveSystem ..> enemyHealth
waveSystem ..> WaypointFollower
waveSystem ..> TextMeshProUGUI

Tower ..> Projectile
Tower ..> GameObject

TowerPlacement ..> Currency
TowerPlacement ..> RemoveTower
TowerPlacement ..> Tower
TowerPlacement ..> TowerStatus

RemoveTower ..> Currency
RemoveTower ..> TowerPlacement

Projectile ..> enemyHealth
Projectile ..> WaypointFollower

Shop ..> GameObject
Shop ..> Transform

Startbutton ..> SceneManager
Startbutton ..> Button

Quitbutton ..> Application
Quitbutton ..> Button

WaveManager <--> EnemySpawner
TowerPlacement <--> RemoveTower
TowerPlacement <--> Currency


