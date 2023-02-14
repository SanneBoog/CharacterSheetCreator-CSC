<template>
  <div class="wrapper">
    <div id="character">
      <character-select-component id="character-name" @select="handleCharacterSelect"></character-select-component>
      <ul id="character-detail-list">
        <li><p>{{ character.class }} {{ character.level }}</p>CLASS & LEVEL</li>
        <li><p>{{ character.background }}</p>BACKGROUND</li>
        <li><p>{{ character.playerName }}</p>PLAYERNAME</li>
        <li><p>{{ character.race }}</p>RACE</li>
        <li><p>{{ character.alignment }}</p>ALIGNMENT</li>
        <li><p>{{ character.experiencepoints }}</p>EXPERIENCEPOINTS</li>
      </ul>
    </div>
    <div id="align-left-side">
      <div id="character-abilities">
      <character-abilities :characterId="character.characterId" @characterIdChanged="handleCharacterIdChanged"></character-abilities>
    </div>
    <div id="inspiration-points">
      <p id="points">1</p>
      <p id="title-points">Inspiration Points</p>
    </div>
    <div id="proficiency-bonus">
      <proficiency-bonus :level="character.level"></proficiency-bonus>
    </div>
    </div>
  </div>
</template>

<script>
import ProficiencyBonus from './ProficiencyBonus.vue'
import CharacterSelectComponent from '../APIComponents/CharacterSelectComponent.vue'
import CharacterAbilities from './CharacterAbilities.vue'

import axios from 'axios'

export default {
  name: 'CharacterDetails',
  components: {
    ProficiencyBonus,
    CharacterSelectComponent,
    CharacterAbilities,
  },
  data() {
    return {
      character: {
        characterId: null,
        characterName: 'placeholder',
        class: 'placeholder',
        level: null,
        background: 'placeholder',
        playerName: 'placeholder',
        race: 'placeholder',
        alignment: 'placeholder',
        experiencepoints: 'placeholder',
      }
    }
  },
  methods: {
    handleCharacterSelect(characterId) {
      if (!characterId) {
        characterId = this.characterIds[0];
      }
      axios.get(`https://localhost:7027/api/character/${characterId}`)
      .then(response => {
        this.character = response.data
      })
    },
    handleCharacterIdChanged(newCharacterId) {
      this.character.characterId = newCharacterId;
    },
    mounted(){
  this.handleCharacterSelect(this.characterIds[1])
}
  }
}
</script>
<style>
    .wrapper{
      max-width: 1100px;
      margin: 0 auto;
    }
    #align-left-side{
      display: block;
      max-width:320px;
    }
    #inspiration-points{
      margin-top: -13px;
  margin-bottom: 11px;
    text-align: center;
    float: right;
    display: block;
    min-width: 186px;
    height: 46px;
    background-image: url('D:\Java\Charsheet\charsheet\src\assets\inspiration-background.png');
    background-size: cover;
    background-repeat: no-repeat;
    }
    #inspiration-points p{
      display: inline-block;
      line-height: 12px;
    }
    #points{
      font-size: 16px;
      margin-right: 30px;
    }
    #title-points{
      font-size:13px;
      margin-right: 9px;
    }
    #character-abilities{
      min-width: 107px;
      float: left;
      display: block;
    }
    #proficiency-bonus{
      float:right;
    }
    #character{
      max-width: 1100px;
      max-height: 300px;
      position: relative;
      margin: 0 auto;
    }
    #character-name{
      position: absolute;
      margin: 0;
      top: 50%;
      max-width: 400px;
    }
    #character-detail-list{
      display: block;
      max-width: 700px;
      margin-left: auto; 
      margin-right: 0;
      font-size: 11px;
    }
    #character-detail-list li{
      margin-left: 0;
      text-align: left;
      display:inline-block;
      width: 200px;
    }
    #character-detail-list li p{
      font-size: 13px;
      margin-top: 15px;
      margin-bottom: 5px;
      max-width: 180px;
      border-bottom: solid 1px #000;
    }
</style>