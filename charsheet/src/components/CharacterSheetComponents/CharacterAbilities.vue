<template>
  <div id="AbilityScores">
    <div class="ability-wrapper">
      <p class="ability-title">STRENGTH</p> 
      <p class="ability-score">{{ abilityscores.strength }} </p>
      <p><ability-modifier :score="abilityscores.strength" class="ability-modifier"></ability-modifier></p>
    </div>
    <span>test</span>
    <div class="ability-wrapper">
      <p class="ability-title">DEXTERITY</p> 
      <p class="ability-score">{{ abilityscores.dexterity }} </p>
      <p><ability-modifier :score="abilityscores.dexterity" class="ability-modifier"></ability-modifier></p>
    </div>
    <div class="ability-wrapper">
      <p class="ability-title">CONSTITUTION</p> 
      <p class="ability-score">{{ abilityscores.constitution }} </p>
      <p><ability-modifier :score="abilityscores.constitution" class="ability-modifier"></ability-modifier></p>
    </div>
    <div class="ability-wrapper">
      <p class="ability-title">INTELLIGENCE</p> 
      <p class="ability-score">{{ abilityscores.intelligence }} </p>
      <p><ability-modifier :score="abilityscores.intelligence" class="ability-modifier"></ability-modifier></p>
    </div>
    <div class="ability-wrapper">
      <p class="ability-title">WISDOM</p> 
      <p class="ability-score">{{ abilityscores.wisdom }} </p>
      <p><ability-modifier :score="abilityscores.wisdom" class="ability-modifier"></ability-modifier></p>
    </div>
  </div>
</template>

<script>
import AbilityModifier from './AbilityModifier.vue'
import axios from 'axios'

export default {
  name: 'CharacterAbilities',
  
  components: {
    AbilityModifier,
  },
  props: ['characterId'],

  data() {
    return {
      abilityscores: {
        strength: 0,
        dexterity: 0,
        constitution: 0,
        intelligence: 0,
        wisdom: 0,
        charisma: 0
      }
    }
  },
  methods: {
    async fetchAbilityScores(characterId) {
      try {
        const response = await axios.get(`https://localhost:7027/api/abilityScores/${characterId}`);
        this.abilityscores = response.data;
      } catch (error) {
        console.error(error);
      }
    }
  },
  created() {
    this.fetchAbilityScores(this.characterId);
  },
  watch: {
    characterId: function(newVal) {
      this.fetchAbilityScores(newVal);
    }
  }
}
</script>
<style>
  .ability-wrapper{
    max-width: 107px;
    height: 126px;
    text-align: center;
    background-image: url('D:\Java\Charsheet\charsheet\src\assets\ability-background.png');
    background-size: cover;
    background-repeat: no-repeat;
  }
  .ability-title{
    font-size: 11px;
    text-align: center;
    line-height: 3;
  }

  .ability-score{
    font-size: 25px;
    line-height: 0px;
  }

  .ability-modifier{
    line-height: 43px;
    font-size: 15px;
  }
</style>