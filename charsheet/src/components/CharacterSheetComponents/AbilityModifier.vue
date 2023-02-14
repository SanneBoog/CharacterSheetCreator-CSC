<template>
    <div>
      <p>{{ modifier }}</p>
    </div>
  </template>
  
  <script>
  export default {
    name: 'AbilityModifier',
    props: {
      score: {
        type: Number,
        required: true
      }
    },
    computed: {
      modifier() {
        return Math.floor((this.score - 10) / 2)
      }
    }
  }
  </script>