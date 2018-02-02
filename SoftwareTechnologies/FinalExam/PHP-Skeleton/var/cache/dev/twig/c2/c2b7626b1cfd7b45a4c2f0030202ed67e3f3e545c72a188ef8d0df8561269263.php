<?php

/* base.html.twig */
class __TwigTemplate_a17f9d7aa975e34f4e0cc44eeab7f33089147d69ffdc6090114c99e26dfbd157 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f5b2674def7d1df71e9a4d4c194cc4f12796ae0535d9151f2096419008b336bf = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f5b2674def7d1df71e9a4d4c194cc4f12796ae0535d9151f2096419008b336bf->enter($__internal_f5b2674def7d1df71e9a4d4c194cc4f12796ae0535d9151f2096419008b336bf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_17a6ffb56dabdb8259171a0f040e102e88f5fa3f2e175e1d091c434137e8b7c8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_17a6ffb56dabdb8259171a0f040e102e88f5fa3f2e175e1d091c434137e8b7c8->enter($__internal_17a6ffb56dabdb8259171a0f040e102e88f5fa3f2e175e1d091c434137e8b7c8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_f5b2674def7d1df71e9a4d4c194cc4f12796ae0535d9151f2096419008b336bf->leave($__internal_f5b2674def7d1df71e9a4d4c194cc4f12796ae0535d9151f2096419008b336bf_prof);

        
        $__internal_17a6ffb56dabdb8259171a0f040e102e88f5fa3f2e175e1d091c434137e8b7c8->leave($__internal_17a6ffb56dabdb8259171a0f040e102e88f5fa3f2e175e1d091c434137e8b7c8_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_b53940125992afdabe30c1d6a8b32618c16f15b4cc4be0c40f286ff059fb8265 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b53940125992afdabe30c1d6a8b32618c16f15b4cc4be0c40f286ff059fb8265->enter($__internal_b53940125992afdabe30c1d6a8b32618c16f15b4cc4be0c40f286ff059fb8265_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_5c381338ddb9253b5a822a19c25b6e0663af5fee9bbc6edae3a6f1ef497775de = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5c381338ddb9253b5a822a19c25b6e0663af5fee9bbc6edae3a6f1ef497775de->enter($__internal_5c381338ddb9253b5a822a19c25b6e0663af5fee9bbc6edae3a6f1ef497775de_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Project Rider";
        
        $__internal_5c381338ddb9253b5a822a19c25b6e0663af5fee9bbc6edae3a6f1ef497775de->leave($__internal_5c381338ddb9253b5a822a19c25b6e0663af5fee9bbc6edae3a6f1ef497775de_prof);

        
        $__internal_b53940125992afdabe30c1d6a8b32618c16f15b4cc4be0c40f286ff059fb8265->leave($__internal_b53940125992afdabe30c1d6a8b32618c16f15b4cc4be0c40f286ff059fb8265_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_21292e0b0076dbfab8b410662c21664986cf090059921c34ec6f9e45ff138cfa = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_21292e0b0076dbfab8b410662c21664986cf090059921c34ec6f9e45ff138cfa->enter($__internal_21292e0b0076dbfab8b410662c21664986cf090059921c34ec6f9e45ff138cfa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_32530cf071754c402bc1162b69fa285329068df8cd288e309fde6b407a915f31 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_32530cf071754c402bc1162b69fa285329068df8cd288e309fde6b407a915f31->enter($__internal_32530cf071754c402bc1162b69fa285329068df8cd288e309fde6b407a915f31_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_32530cf071754c402bc1162b69fa285329068df8cd288e309fde6b407a915f31->leave($__internal_32530cf071754c402bc1162b69fa285329068df8cd288e309fde6b407a915f31_prof);

        
        $__internal_21292e0b0076dbfab8b410662c21664986cf090059921c34ec6f9e45ff138cfa->leave($__internal_21292e0b0076dbfab8b410662c21664986cf090059921c34ec6f9e45ff138cfa_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_4c4b48bfbda6013b714ed7384eb260ab8ebd82c6bbbc8fe3b9aae3f5dda4c7d1 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4c4b48bfbda6013b714ed7384eb260ab8ebd82c6bbbc8fe3b9aae3f5dda4c7d1->enter($__internal_4c4b48bfbda6013b714ed7384eb260ab8ebd82c6bbbc8fe3b9aae3f5dda4c7d1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_472216417368cabcf0b328166ac9e43dd22f72bf126662c94e65081586f7c0d1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_472216417368cabcf0b328166ac9e43dd22f72bf126662c94e65081586f7c0d1->enter($__internal_472216417368cabcf0b328166ac9e43dd22f72bf126662c94e65081586f7c0d1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_472216417368cabcf0b328166ac9e43dd22f72bf126662c94e65081586f7c0d1->leave($__internal_472216417368cabcf0b328166ac9e43dd22f72bf126662c94e65081586f7c0d1_prof);

        
        $__internal_4c4b48bfbda6013b714ed7384eb260ab8ebd82c6bbbc8fe3b9aae3f5dda4c7d1->leave($__internal_4c4b48bfbda6013b714ed7384eb260ab8ebd82c6bbbc8fe3b9aae3f5dda4c7d1_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_fb2facbbc304a924be453d926eebdc5279391ea3858a6e555585814b306570f7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fb2facbbc304a924be453d926eebdc5279391ea3858a6e555585814b306570f7->enter($__internal_fb2facbbc304a924be453d926eebdc5279391ea3858a6e555585814b306570f7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_f92ac94e726be7b907b739de69daed7d0cb0a98850594ed7ea33bcc80baa48b1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f92ac94e726be7b907b739de69daed7d0cb0a98850594ed7ea33bcc80baa48b1->enter($__internal_f92ac94e726be7b907b739de69daed7d0cb0a98850594ed7ea33bcc80baa48b1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_f92ac94e726be7b907b739de69daed7d0cb0a98850594ed7ea33bcc80baa48b1->leave($__internal_f92ac94e726be7b907b739de69daed7d0cb0a98850594ed7ea33bcc80baa48b1_prof);

        
        $__internal_fb2facbbc304a924be453d926eebdc5279391ea3858a6e555585814b306570f7->leave($__internal_fb2facbbc304a924be453d926eebdc5279391ea3858a6e555585814b306570f7_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_955e5ca8f3efc6863eccfa09b0d197908ef376b984e4f75e2d82557ca648b286 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_955e5ca8f3efc6863eccfa09b0d197908ef376b984e4f75e2d82557ca648b286->enter($__internal_955e5ca8f3efc6863eccfa09b0d197908ef376b984e4f75e2d82557ca648b286_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_f9a5dd1c8f499472462ca2af61cbf82c5f7c1d2694a91d24fd7db0444784ba7d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f9a5dd1c8f499472462ca2af61cbf82c5f7c1d2694a91d24fd7db0444784ba7d->enter($__internal_f9a5dd1c8f499472462ca2af61cbf82c5f7c1d2694a91d24fd7db0444784ba7d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_f9a5dd1c8f499472462ca2af61cbf82c5f7c1d2694a91d24fd7db0444784ba7d->leave($__internal_f9a5dd1c8f499472462ca2af61cbf82c5f7c1d2694a91d24fd7db0444784ba7d_prof);

        
        $__internal_955e5ca8f3efc6863eccfa09b0d197908ef376b984e4f75e2d82557ca648b286->leave($__internal_955e5ca8f3efc6863eccfa09b0d197908ef376b984e4f75e2d82557ca648b286_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Project Rider{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Projects\\PHP-Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
