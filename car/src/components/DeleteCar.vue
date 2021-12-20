<template>
<div class="all">
  <h1>Delete car</h1>
  <form @submit.prevent = "DeleteCar">
    <div class="input-field">
      <input type="text" name="Id" placeholder="Id" v-model="CarId"><br>
      <input type="submit">
    </div>
  </form>


</div>
</template>

<script>
import axios from "axios";

export default {
  name: "DeleteCar",
  data() {
    return {
      CarId: ''
    };
  },
  methods: {
    DeleteCar(){
      axios.delete('carlist/'+this.CarId).then(res => {
        console.log(res)
      })
    }
  }

}

</script>

<style scoped>

</style>