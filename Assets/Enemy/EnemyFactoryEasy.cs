public class EnemyFactoryEasy : IEnemyFactory {

	public IEnemyA createEnemyA(){
		return new EnemyA1 ();
	}
	public IEnemyB createEnemyB(){
		return new EnemyB1 ();
	}
}
