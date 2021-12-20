<template>
<div class="all">
  <h1>Delete car</h1>
  <form @submit.prevent = "DeleteCar" class="uk-form-stacked">
    <div class="uk-margin">
      <label for="Id" class="uk-form-label">Номер машини</label>
      <input type="text" name="Id" placeholder="Id" v-model="CarId" class="uk-input uk-width-medium uk-form-controls"><br>
    </div>
    <input type="submit" class="uk-button uk-button-default" value="Delete">
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
    async DeleteCar(){
      await axios.delete('carlist/'+this.CarId).then(res => {
        console.log(res)
      })
      this.CarId = '';
      this.$emit('dataRefreshEvent')
    }
  }

}

</script>

<style scoped>

</style>