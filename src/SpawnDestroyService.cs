namespace DefaultNamespace;

public class SpawnDestroyService
{
    public int artifactMax = 20;
    public List<Artifact> artifactsList = new();

    public void spawnArtifact(char artifact) {
        switch(artifact) {
            case 'b':
                Bomb bomb = new();
                bomb.setArtifactType('b');
                bomb.setXYCoordinate();
                bomb.randomFallSpeed();
                artifactsList.Add(bomb);
                break;
            case 'g':
                Gem gem = new();
                gem.setArtifactType('g');
                gem.setXYCoordinate();
                gem.randomFallSpeed();
                artifactsList.Add(gem);
                break;
            case 'r':
                Rock rock = new();
                rock.setArtifactType('r');
                rock.setXYCoordinate();
                rock.randomFallSpeed();
                artifactsList.Add(rock);
                break;
        }
    }

    public bool checkIfSpawnNeeded() {
        if(artifactMax - (artifactsList.Count - 1) > 0) {
            return true;
        }
        else {
            return false;
        }
    }

    public List<Artifact> GetArtifacts() {
        return artifactsList;
    }

    public void makeArtifactFall() {
        for(int i = 0; i < artifactsList.Count; i++) {
            artifactsList[i].fall();

            if (artifactsList[i].y1 > Director.screenHeight) {
                artifactsList.RemoveAt(i);
            }
        }
    }

    public void collideCheckAll(Player player) {
        for(int i = 0; i < artifactsList.Count; i++) {
            if (artifactsList[i].checkCollision(player.x1, player.y1, player.radius)) {
                switch(artifactsList[i].artifactName) {
                    case 'b':
                        ScoreManager.scoreHalf();
                        artifactsList.RemoveAt(i);
                        break;
                    case 'g':
                        ScoreManager.scoreUp();
                        artifactsList.RemoveAt(i);
                        break;
                    case 'r':
                        ScoreManager.scoreDown();
                        artifactsList.RemoveAt(i);
                        break;
                }
            }
        }
    }
}