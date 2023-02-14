<template>
    <div>
      <select @change="selectCharacter" v-model="selectedCharacterId">
        <option v-for="character in characters" :key="character.characterId" :value="character.characterId">{{ character.characterName }}</option>
      </select>
    </div>
  </template>
  
  <script>
  import axios from 'axios'
  export default {
  name: 'CharacterSelectComponent',
  data() {
    return {
      characters: [],
      selectedCharacterId: null
    }
  },
  created() {
    axios.get('https://localhost:7027/api/characters/all')
      .then(response => {
        this.characters = response.data
      })
  },
  methods: {
    selectCharacter(event) {
      this.$emit('select', event.target.value)
    }
  }
}
  </script>
  