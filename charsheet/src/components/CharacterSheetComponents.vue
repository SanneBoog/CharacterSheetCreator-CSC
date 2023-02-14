<template>
    <div>
      <button @click="showComponent1 = true; showComponent2 = false">Show Sheets</button>
      <button @click="showComponent1 = false; showComponent2 = true">Create new sheet</button>
      <CharacterDetails v-if="showComponent1"></CharacterDetails>
      <CharacterCreateComponent v-if="showComponent2"></CharacterCreateComponent>
    </div>
  </template>
  
  <script>
import CharacterDetails from './CharacterSheetComponents/CharacterDetails.vue';
import CharacterCreateComponent from './APIComponents/CharachterCreateComponent.vue';

  export default {
    name: 'CharacterSheetComponent',
    components: {
        CharacterDetails,
        CharacterCreateComponent
  },
    data() {
      return {
        showComponent1: true,
        showComponent2: false
      }
    }
  }
  </script>
  