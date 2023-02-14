<template>
  <div id="app">
    <CharacterSheetComponent/>

  </div>
</template>

<script>
import CharacterSheetComponent from './components/CharacterSheetComponents.vue'

export default {
  name: 'App',
  components: {
    CharacterSheetComponent,
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
