<template>
  <div>
    <div id="proficiency-bonus">
      <p id="calculated-bonus">{{ proficiencyBonus }}</p>
      <p id="title-bonus">Proficiency Bonus</p>
    </div>
    <div>
      <SavingThrows :proficiencyBonus="proficiencyBonus"></SavingThrows>
    </div>
  </div>
    
</template>

<script>
import SavingThrows from './SavingThrows.vue'

  export default {
    name: 'ProficiencyBonus',
    components: {
    SavingThrows
  },
    props: {
      level: {
        type: Number,
        required: true
      }
    },
    computed: {
      proficiencyBonus() {
        if (this.level >= 1 && this.level <= 4) {
          return 2
        } else if (this.level >= 5 && this.level <= 8) {
          return 3
        } else if (this.level >= 9 && this.level <= 12) {
          return 4
        } else if (this.level >= 13 && this.level <= 16) {
          return 5
        } else if (this.level >= 17 && this.level <= 20) {
          return 6
        }
        return 0
      }
    }
  }
  </script>
  <style>
    #proficiency-bonus{
    width: 189px;
    height: 58px;
    background-image: url('D:\Java\Charsheet\charsheet\src\assets\proficiency-background.png');
    background-size: cover;
    background-repeat: no-repeat;
    }
    #proficiency-bonus p{
      display: inline-block;
    }
    #calculated-bonus{
      margin-right: 30px;
      font-size: 18px;
    }
    #title-bonus{
      font-size:13px;
    }
  </style>