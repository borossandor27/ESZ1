<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('products', function (Blueprint $table) {
            $table->id();
            /* Add additional fields */
            $table->text('title');  // product title
            $table->text('description');   // description
            $table->text('short_notes');   // short notes
            $table->decimal('price', 10, 2); // price
            $table->text('image'); // product image
            $table->text('slug'); // product slug
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('products');
    }
};