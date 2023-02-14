<template>
<div>
    <form>
        <input v-model="character.characterName" type="text" placeholder="Character Name">
        <input v-model="character.class" type="text" placeholder="Class">
        <input v-model="character.level" type="text" placeholder="Level">
        <input v-model="character.background" type="text" placeholder="Background">
        <input v-model="character.playerName" type="text" placeholder="Player Name">
        <input v-model="character.race" type="text" placeholder="Race">
        <input v-model="character.alignment" type="text" placeholder="Alignment">
        <input v-model="character.experiencepoints" type="text" placeholder="Experience Points">
    </form>
    <button v-on:click="sendData()">Submit</button>
</div>
</template>
  
  <script>
  import axios from 'axios'
  export default {
  name: 'CharacterCreateComponent',
  data() {
    return {
        character: {
        characterId: null,
        characterName: '',
        class: '',
        level: null,
        background: '',
        playerName: '',
        race: '',
        alignment: '',
        experiencepoints: '',
      }
    }
  },
  methods: {
    sendData(){
        axios.post("https://localhost:7027/api/character/create", this.character)
    .catch(error => {
      this.errorMessage = error.message;
      console.error("There was an error!", error);
    });
    }
}}
  </script>
  